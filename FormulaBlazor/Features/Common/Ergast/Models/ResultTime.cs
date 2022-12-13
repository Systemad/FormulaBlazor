using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class ResultTime
{
    [JsonPropertyName("millis")]
    public string Millis { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }
}
