using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Ergast.Models;

public abstract class ResultBase
{
    [JsonPropertyName("number")]
    public string Number { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("Driver")]
    public Driver Driver { get; set; }

    [JsonPropertyName("Constructor")]
    public Constructor Constructor { get; set; }
}
