using FormulaBlazor.Features.Drivers.Models;

namespace FormulaBlazor.Features.Teams.Models;

public class StandingsTable
{
    public string Season { get; set; }
    public List<StandingsList> StandingsLists { get; set; }
}