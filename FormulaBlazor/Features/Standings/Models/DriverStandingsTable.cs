using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Drivers.Models;

public class DriverStandingsTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }
    
    [JsonPropertyName("StandingsLists")]
    public List<StandingsList> StandingsLists { get; set; }
}