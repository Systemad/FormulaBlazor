using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Drivers.Models;

public class StandingsList
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("DriverStandings")]
    public List<DriverStanding> DriverStandings { get; set; }
}