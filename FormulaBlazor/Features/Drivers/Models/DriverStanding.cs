using System.Text.Json.Serialization;
using FormulaBlazor.Features.Teams.Models;

namespace FormulaBlazor.Features.Drivers.Models;

public class DriverStanding
{
    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("wins")]
    public string Wins { get; set; }

    [JsonPropertyName("Driver")]
    public Driver Driver { get; set; }

    [JsonPropertyName("Constructors")]
    public List<Constructor> Constructors { get; set; }
}