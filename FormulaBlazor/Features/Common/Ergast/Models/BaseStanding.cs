using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public abstract class BaseStanding
{
    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("wins")]
    public string Wins { get; set; }
}
