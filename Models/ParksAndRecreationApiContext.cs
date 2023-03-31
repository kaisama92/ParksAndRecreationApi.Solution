using Microsoft.EntityFrameworkCore;

namespace ParksAndRecreationApi.Models
{
  public class ParksAndRecreationApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksAndRecreationApiContext(DbContextOptions<ParksAndRecreationApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>().HasData(
        new Park { ParkId = 1, ParkName = "Willamette Stone State Heritage Site", IsStatePark = true, HasBathrooms = false, HasFamilyFriendlyBathrooms = false, HasPlayStructure = false, Latitude = "45.52075 N", Longitude = "122.74365 W"},
        new Park { ParkId = 2, ParkName = "Wapato Access Greenway State Park", IsStatePark = true, HasBathrooms = false, HasFamilyFriendlyBathrooms = false, HasPlayStructure = false, Latitude = "45.66018 N", Longitude = "122.83870 W"},
        new Park { ParkId = 3, ParkName = "Fort Vanouver National Historic Site", IsNationalPark = true, HasFamilyFriendlyBathrooms = true, HasPlayStructure = false, Latitude = "45.62280 N", Longitude = "122.66215 W"}
        );
    }
  }
}