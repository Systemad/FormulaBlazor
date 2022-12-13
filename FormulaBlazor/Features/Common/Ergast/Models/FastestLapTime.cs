using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class FastestLapTime
{
    [JsonPropertyName("time")]
    public string Time { get; set; }
}
