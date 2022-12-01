using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast;

namespace FormulaBlazor.Features.Results.Models;

public class Results
{
    [JsonPropertyName("MRData")]
    public MrData MrData { get; set; }
}

public class MrData : MrDataRoot
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
    public List<Race> Races { get; set; }
}

public class Race
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }

    [JsonPropertyName("raceName")]
    public string RaceName { get; set; }

    [JsonPropertyName("Circuit")]
    public Circuit Circuit { get; set; }

    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("Results")]
    public List<Result> Results { get; set; }
}

public class Circuit
{
    [JsonPropertyName("circuitId")]
    public string CircuitId { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }

    [JsonPropertyName("circuitName")]
    public string CircuitName { get; set; }

    [JsonPropertyName("Location")]
    public Location Location { get; set; }
}

public class Location
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    [JsonPropertyName("long")]
    public string Long { get; set; }

    [JsonPropertyName("locality")]
    public string Locality { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }
}

public class Result
{
    [JsonPropertyName("number")]
    public string Number { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("positionText")]
    public string PositionText { get; set; }

    [JsonPropertyName("points")]
    public string Points { get; set; }

    [JsonPropertyName("Driver")]
    public Driver Driver { get; set; }

    [JsonPropertyName("Constructor")]
    public Constructor Constructor { get; set; }

    [JsonPropertyName("grid")]
    public string Grid { get; set; }

    [JsonPropertyName("laps")]
    public string Laps { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("Time")]
    public ResultTime Time { get; set; }

    [JsonPropertyName("FastestLap")]
    public FastestLap FastestLap { get; set; }
}

public class Constructor
{
    [JsonPropertyName("constructorId")]
    public string ConstructorId { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }

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
    public Uri Url { get; set; }

    [JsonPropertyName("givenName")]
    public string GivenName { get; set; }

    [JsonPropertyName("familyName")]
    public string FamilyName { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string DateOfBirth { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }
}

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

public class AverageSpeed
{
    [JsonPropertyName("units")]
    public string Units { get; set; }

    [JsonPropertyName("speed")]
    public string Speed { get; set; }
}

public class FastestLapTime
{
    [JsonPropertyName("time")]
    public string Time { get; set; }
}

public class ResultTime
{
    [JsonPropertyName("millis")]
    public string Millis { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }
}
