using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Calendar.Models;

public class CalendarResponse
{
    [JsonPropertyName("MRData")]
    public CalendarResponseRoot MrData { get; set; }
}

public class CalendarResponseRoot : MrDataRoot
{
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
    public FirstPractice Sprint { get; set; }
}

public class FirstPractice
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }
}
