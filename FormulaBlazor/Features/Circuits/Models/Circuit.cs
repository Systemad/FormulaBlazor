using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast;

namespace FormulaBlazor.Features.Circuits.Models;

public class Circuit : MrDataRoot
{
    [JsonPropertyName("MRData")]
    public MrData MrData { get; set; }
}

public class MrData : MrDataRoot
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

    [JsonPropertyName("CircuitTable")]
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
