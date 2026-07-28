public class Vehicle
{
    public string VehicleNumber { get; set; } = "";
    public string VehicleType { get; set; } = "";
    public string JourneyType { get; set; } = "";

    public bool FASTagAvailable { get; set; }
    public bool PeakHour { get; set; }
}