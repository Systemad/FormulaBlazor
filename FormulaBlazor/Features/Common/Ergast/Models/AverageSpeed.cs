using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class AverageSpeed
{
    [JsonPropertyName("units")]
    public string Units { get; set; }

    [JsonPropertyName("speed")]
    public string Speed { get; set; }
}
