using FormulaBlazor.Utilities;

namespace FormulaBlazor.Features.Standings;

public partial class Standings
{
    private int SelectedSeason { get; set; } = DateTime.UtcNow.Year;
    private List<int> SeasonList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        SeasonList = SeasonHelper.GetSeasons();
        //await InitializeDriverAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDriverAsync()
    {
        //DriverDto = driver.Root.DriverStandingsTable.StandingsLists.
        // data.Root.DriverStandingsTable.StandingsLists[0];
    }

    private void OnSelectSeasonChanged(int season)
    {
        Console.WriteLine("Season: " + season);
        SelectedSeason = season;
    }
}
