using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Results.Models;

public class RaceResultsResponse
{
    [JsonPropertyName("MRData")]
    public RaceResultsRoot MrData { get; set; }
}

public class RaceResultsRoot : MrDataRoot
{
    [JsonPropertyName("RaceTable")]
    public RaceTable RaceTable { get; set; }
}

public class RaceTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("Races")]
    public List<RaceWithResults> Races { get; set; }
}
