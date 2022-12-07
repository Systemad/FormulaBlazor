using FormulaBlazor.Features.Calendar.Models;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Constructors.Models;
using FormulaBlazor.Features.Drivers.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Pages;

public partial class Index
{
    [Inject]
    private IBaseErgastClient Client { get; set; }
    private ConstructorStandingsList? ConstructorStandingList { get; set; }
    private DriverStandingsList? DriverStandingsList { get; set; }
    private ScheduleDto? RaceTable { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //await InitializeDashboardAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDashboardAsync()
    {
        var constructorsResponse = await Client.GetAsync<ConstructorStandingRoot>(
            "current/constructorStandings.json"
        );
        ConstructorStandingList = constructorsResponse.MrData.StandingsTable.StandingsLists[0];

        var driversResponse = await Client.GetAsync<DriverStandingsRoot>(
            "current/driverStandings.json"
        );
        DriverStandingsList = driversResponse.MrData.StandingsTable.StandingsLists[0];

        //await FetchAndInitCalendar();
    }

    private async Task FetchAndInitCalendar()
    {
        var calendarResponse = await Client.GetAsync<CalendarRoot>("current.json");
        var oldStand = calendarResponse.MrData.RaceTable;
        RaceTable = oldStand.MapScheduleDto();
        RaceTable.Races.RemoveAll(a => a.Date.Month < DateTime.UtcNow.Month);
        var enumerable = RaceTable.Races.Take(3).ToList();
        RaceTable.Races = enumerable;
    }
}
