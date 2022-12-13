using System.Text.Json.Serialization;
using FormulaBlazor.Features.Results.Models;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class FastestLap
{
    [JsonPropertyName("rank")]
    public string Rank { get; set; }

    [JsonPropertyName("lap")]
    public string Lap { get; set; }

    [JsonPropertyName("Time")]
    public FastestLapTime Time { get; set; }

    [JsonPropertyName("AverageSpeed")]
    public AverageSpeed AverageSpeed { get; set; }
}
