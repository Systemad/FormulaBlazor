using System.Globalization;
using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

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

    public DateTime StartTime =>
        DateTime.Parse(
            Date + " " + Time,
            CultureInfo.InvariantCulture,
            DateTimeStyles.AdjustToUniversal
        );

    [JsonPropertyName("time")]
    public string Time { get; set; }
}
