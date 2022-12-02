using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Drivers.Models;

public class DriverStandingsRoot
{
    [JsonPropertyName("MRData")]
    public MrData MrData { get; set; }
}

public class MrData
{
    [JsonPropertyName("xmlns")]
    public string Xmlns { get; set; }

    [JsonPropertyName("series")]
    public string Series { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

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

    [JsonPropertyName("DriverStandings")]
    public List<DriverStanding> DriverStandings { get; set; }
}

public class DriverStanding
{
    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("wins")]
    public string Wins { get; set; }

    [JsonPropertyName("Driver")]
    public Driver Driver { get; set; }

    [JsonPropertyName("Constructors")]
    public List<Constructor> Constructors { get; set; }
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

public class Driver
{
    [JsonPropertyName("driverId")]
    public string DriverId { get; set; }

    [JsonPropertyName("permanentNumber")]
    public string PermanentNumber { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("givenName")]
    public string GivenName { get; set; }

    [JsonPropertyName("familyName")]
    public string FamilyName { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string DateOfBirth { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }
}
