using FormulaBlazor.Features.Calendar.Models;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Common.Ergast.Models;
using FormulaBlazor.Features.Constructors.Models;
using FormulaBlazor.Features.Drivers.Models;
using FormulaBlazor.Features.Results.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Pages;

public partial class Index
{
    [Inject]
    private IBaseErgastClient Client { get; set; }
    private ConstructorStandingsList? ConstructorStandingList { get; set; }
    private DriverStandingsList? DriverStandingsList { get; set; }
    private ScheduleDto? RaceTable { get; set; }

    private RaceWithResults? RecentRace { get; set; }

    private bool IsSeasonDone { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await InitializeDashboardAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDashboardAsync()
    {
        var constructorsResponse = await Client.GetAsync<ConstructorStandingResponse>(
            "current/constructorStandings.json"
        );
        ConstructorStandingList = constructorsResponse.MrData.StandingsTable.StandingsLists[0];

        var driversResponse = await Client.GetAsync<DriverStandingsRoot>(
            "current/driverStandings.json"
        );
        DriverStandingsList = driversResponse.MrData.StandingsTable.StandingsLists[0];

        await FetchAndInitCalendar();
        await FetchMostRecentRace();
    }

    private async Task FetchAndInitCalendar()
    {
        var calendarResponse = await Client.GetAsync<CalendarResponse>("current.json");
        var oldStand = calendarResponse.MrData.RaceTable;
        RaceTable = oldStand.MapScheduleDto();
        var seasonDone = RaceTable.Races.All(a => a.Date.Month < DateTime.UtcNow.Month);
        if (seasonDone)
        {
            IsSeasonDone = true;
        }
        else
        {
            IsSeasonDone = false;
            RaceTable.Races.RemoveAll(a => a.Date.Month < DateTime.UtcNow.Month);
            var enumerable = RaceTable.Races.Take(3).ToList();
            RaceTable.Races = enumerable;
        }
    }

    private async Task FetchMostRecentRace()
    {
        var data = await Client.GetAsync<RaceResultsResponse>("current/last/results.json");
        var result = data.MrData.RaceTable;
        RecentRace = result.Races.Last();
    }
}
