using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Constructors.Models;

public class ContructorStandingRoot
{
    [JsonPropertyName("MRData")]
    public MrData MrData { get; set; }
}

public class MrData
{
    [JsonPropertyName("xmlns")]
    public Uri Xmlns { get; set; }

    [JsonPropertyName("series")]
    public string Series { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }

    [JsonPropertyName("limit")]
    public string Limit { get; set; }

    [JsonPropertyName("offset")]
    public string Offset { get; set; }

    [JsonPropertyName("total")]
    public string Total { get; set; }

    [JsonPropertyName("StandingsTable")]
    public StandingsTable StandingsTable { get; set; }
}

public class StandingsTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("StandingsLists")]
    public List<StandingsList> StandingsLists { get; set; }
}

public class StandingsList
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("ConstructorStandings")]
    public List<ConstructorStanding> ConstructorStandings { get; set; }
}

public class ConstructorStanding
{
    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("wins")]
    public string Wins { get; set; }

    [JsonPropertyName("Constructor")]
    public Constructor Constructor { get; set; }
}

public class Constructor
{
    [JsonPropertyName("constructorId")]
    public string ConstructorId { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }
}
