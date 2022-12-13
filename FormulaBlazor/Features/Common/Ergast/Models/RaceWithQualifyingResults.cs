using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public class RaceWithQualifyingResults : Race
{
    [JsonPropertyName("QualifyingResults")]
    public List<QualifyingResult> QualifyingResults { get; set; }
}
