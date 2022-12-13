using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class RaceWithResults : Race
{
    [JsonPropertyName("Results")]
    public List<RaceResult> Results { get; set; }
}
