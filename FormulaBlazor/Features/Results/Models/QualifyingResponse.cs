using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Results.Models;

public class QualifyingResponse
{
    [JsonPropertyName("MRData")]
    public QualifyingResponseRoot MrData { get; set; }
}

public class QualifyingResponseRoot : MrDataRoot
{
    [JsonPropertyName("RaceTable")]
    public QualifyingRaceTable RaceTable { get; set; }
}

public class QualifyingRaceTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("Races")]
    public List<RaceWithQualifyingResults> Races { get; set; }
}
