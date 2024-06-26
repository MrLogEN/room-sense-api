namespace RoomSense.Api.Lib.Models;

public class Cluster
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public IEnumerable<TemperatureHumidity> Records { get; set; } = new List<TemperatureHumidity>();
}