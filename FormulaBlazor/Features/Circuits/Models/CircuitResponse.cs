using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Circuits.Models;

public class CircuitResponse
{
    [JsonPropertyName("MRData")]
    public MrData MrData { get; set; }
}

public class MrData : MrDataRoot
{
    public CircuitTable CircuitTable { get; set; }
}

public class CircuitTable
{
    [JsonPropertyName("Circuits")]
    public List<CircuitElement> Circuits { get; set; }
}

public class CircuitElement
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
