using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Responses;

public abstract class MrDataRoot
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
}
