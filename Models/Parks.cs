namespace ParksAndRecreationApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string County { get; set; }
    public bool HasBathrooms { get; set; }
    public bool HasFamilyFriendlyBathrooms { get; set; }
    public bool HasPlayStructure { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
  }
}