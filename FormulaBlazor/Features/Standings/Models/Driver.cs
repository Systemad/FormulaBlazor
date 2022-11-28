using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Drivers.Models;

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