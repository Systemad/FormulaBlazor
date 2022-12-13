using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Constructors.Models;

public class ConstructorStandingResponse
{
    [JsonPropertyName("MRData")]
    public ConstructorStandingRoot MrData { get; set; }
}

public class ConstructorStandingRoot : MrDataRoot
{
    public StandingsTable StandingsTable { get; set; }
}

public class StandingsTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("StandingsLists")]
    public List<ConstructorStandingsList> StandingsLists { get; set; }
}

public class ConstructorStandingsList
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("ConstructorStandings")]
    public List<ConstructorStanding> ConstructorStandings { get; set; }
}

public class ConstructorStanding : BaseStanding
{
    [JsonPropertyName("Constructor")]
    public Constructor Constructor { get; set; }
}
