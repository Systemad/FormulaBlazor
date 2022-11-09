using FormulaBlazor.Features.Common;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Drivers.DTO;
using FormulaBlazor.Features.Drivers.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Drivers.Pages;

public partial class Driver
{
    [Parameter] public string? DriverId { get; set; }
    
    [Inject] private IBaseErgastClient _client { get; set; }
    private DriverDto DriverDto = new(); 
    
    protected override async Task OnInitializedAsync()
    {
        await InitializeDriverAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDriverAsync()
    {
        var driver = await _client.GetAsync<Response<MRData>>($"drivers/{DriverId}");
        //DriverDto = driver.Root.DriverStandingsTable.StandingsLists.
            // data.Root.DriverStandingsTable.StandingsLists[0];
    }
}