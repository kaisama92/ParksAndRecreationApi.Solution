using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAndRecreationApi.Models;

namespace ParksAndRecreationApi.Controllers
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  // [ApiVersion("2.0")]
  public class ParksController : ControllerBase
  {
    private readonly ParksAndRecreationApiContext _db;

    public ParksController(ParksAndRecreationApiContext db)
    {
      _db = db;
    }

    // GET: api/parks?page=1&pagesize=20
    [HttpGet]
    public async Task<IActionResult> GetParks( int id, string county, string parkName, bool isStatePark = false, bool isNationalPark = false, int page = 1, int pageSize = 10)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }
      if (isNationalPark)
      {  
        query = query.Where(entry => entry.IsNationalPark == true);
      }
      if (isStatePark)
      {
        query = query.Where(entry => entry.IsStatePark == true);
      }
      if (county != null)
      {  
        query = query.Where(entry => entry.County == county);
      }
      if (id != 0)
      {  
        query = query.Where(entry => entry.ParkId  == id);
      }
        // Calculate the number of items to skip based on the page size and requested page. 
        int skip = (page - 1) * pageSize;

        // Retrieve the data from your data source, applying the pagination parameters.  
        List<Park> parks = await query
            .Skip(skip)
            .Take(pageSize)
            .ToListAsync();

        // Determine the total number of items in your data source.
        int totalCount = _db.Parks.Count();

        // Create a response object to hold the paginated data and total count.
        var response = new
        {
            Data = parks,
            TotalCount = totalCount,
            Page = page,
            PageSize = pageSize
        };

        // Return the paginated data to the client.
        return Ok(response);
    }

    // GET: api/parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park Park = await _db.Parks.FindAsync(id);

      if (Park == null)
      {
        return NotFound();
      }

      return Park;
    }
    
    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park Park = await _db.Parks.FindAsync(id);
      if (Park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(Park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}