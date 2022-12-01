namespace FormulaBlazor.Features.Standings.Pages;

public partial class Standings
{
    protected override async Task OnInitializedAsync()
    {
        //await InitializeDriverAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDriverAsync()
    {
        //DriverDto = driver.Root.DriverStandingsTable.StandingsLists.
        // data.Root.DriverStandingsTable.StandingsLists[0];
    }
}
