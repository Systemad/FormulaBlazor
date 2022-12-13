using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class QualifyingResult : ResultBase
{
    [JsonPropertyName("Q1")]
    public string Q1 { get; set; }

    [JsonPropertyName("Q2")]
    public string Q2 { get; set; }

    [JsonPropertyName("Q3")]
    public string Q3 { get; set; }
}
