using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast;

namespace FormulaBlazor.Features.Calendar.Models;

public class MrData : MrDataRoot
{
    [JsonPropertyName("RaceTable")]
    public RaceTable RaceTable { get; set; }
}

public class RaceTable
{
    [JsonPropertyName("season")]
    public string Season { get; set; }

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
    public string Url { get; set; }

    [JsonPropertyName("raceName")]
    public string RaceName { get; set; }

    [JsonPropertyName("Circuit")]
    public Circuit Circuit { get; set; }

    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }

    [JsonPropertyName("FirstPractice")]
    public FirstPractice FirstPractice { get; set; }

    [JsonPropertyName("SecondPractice")]
    public FirstPractice SecondPractice { get; set; }

    [JsonPropertyName("ThirdPractice")]
    public FirstPractice ThirdPractice { get; set; }

    [JsonPropertyName("Qualifying")]
    public FirstPractice Qualifying { get; set; }

    [JsonPropertyName("Sprint")]
    public FirstPractice? Sprint { get; set; }
}

public class Circuit
{
    [JsonPropertyName("circuitId")]
    public string CircuitId { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

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

public class FirstPractice
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }
}
