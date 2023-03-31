namespace ParksAndRecreationApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public bool IsStatePark { get; set; }
    public bool IsNationalPark { get; set; }
    public string County { get; set; }
    public bool HasBathrooms { get; set; }
    public bool HasFamilyFriendlyBathrooms { get; set; }
    public bool HasPlayStructure { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
  }
}