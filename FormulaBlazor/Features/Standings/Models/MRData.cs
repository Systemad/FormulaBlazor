using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common;
using FormulaBlazor.Features.Common.Ergast;

namespace FormulaBlazor.Features.Drivers.Models;

public class MRData : MrDataRoot
{
    [JsonPropertyName("StandingsTable")]
    public DriverStandingsTable DriverStandingsTable { get; set; }
}