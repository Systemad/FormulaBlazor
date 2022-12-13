using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class RaceResult : ResultBase
{
    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("grid")]
    public string Grid { get; set; }

    [JsonPropertyName("laps")]
    public string Laps { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("Time")]
    public ResultTime? Time { get; set; }

    [JsonPropertyName("FastestLap")]
    public FastestLap FastestLap { get; set; }
}
