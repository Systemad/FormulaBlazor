using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Constructors.Models;
using FormulaBlazor.Features.Drivers.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Pages;

public partial class Index
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    private ContructorStandingRoot ContructorStandingRoot { get; set; }
    private DriverStandingsRoot DriverStandingsRoot { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //await InitializeDashboardAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDashboardAsync()
    {
        var constructorsResponse = await _client.GetAsync<ContructorStandingRoot>(
            "current/constructorStandings.json"
        );
        ContructorStandingRoot = constructorsResponse;

        var driversResponse = await _client.GetAsync<DriverStandingsRoot>(
            "current/driverStandings.json"
        );
        DriverStandingsRoot = driversResponse;
    }
}
