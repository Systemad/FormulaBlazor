using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Common.Wikipedia;
using FormulaBlazor.Features.Drivers.DTO;
using FormulaBlazor.Features.Drivers.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaBlazor.Features.Standings.Components;

public partial class DriverStandings
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    [Inject]
    private NavigationManager _navigation { get; set; }

    [Inject]
    private IWikiBaseClient _wikiBaseClient { get; set; }

    private DriverStandingDto _driverStanding = new();

    private MudTable<DriverDto> mudTable;
    private int selectedRowNumber = -1;
    private DriverDto? _selectedDriver;

    //private bool driverSelected = _selectedDriver == null;

    private bool _popOverOpen = false;
    private bool _hidePosition;
    private bool _loading;

    protected override async Task OnInitializedAsync()
    {
        await InitializeDriverStandings();
        await base.OnInitializedAsync();
    }

    private async Task InitializeDriverStandings()
    {
        _loading = true;
        _selectedDriver = null;
        var data = await _client.GetAsync<Response<MRData>>("current/driverStandings.json");
        var oldStand = data.Root.DriverStandingsTable.StandingsLists[0];
        _driverStanding = oldStand.MapToDriverList();
        _loading = false;
    }

    private async Task RowClickEvent(TableRowClickEventArgs<DriverDto> driver)
    {
        if (_selectedDriver == null)
        {
            _selectedDriver = driver.Item;
            _popOverOpen = true;
        }
        else
        {
            _selectedDriver = null;
            _popOverOpen = false;
        }
    }

    private string SelectedRowClassFunc(DriverDto element, int rowNumber)
    {
        if (selectedRowNumber == rowNumber)
        {
            selectedRowNumber = -1;
            //clickedEvents.Add("Selected Row: None");
            //StateHasChanged();
            return string.Empty;
        }
        else if (mudTable.SelectedItem != null && mudTable.SelectedItem.Equals(element))
        {
            selectedRowNumber = rowNumber;
            //StateHasChanged();
            //clickedEvents.Add($"Selected Row: {rowNumber}");
            return "selected";
        }
        else
        {
            //StateHasChanged();
            return string.Empty;
        }
    }

    private void ClosePopover()
    {
        selectedRowNumber = -1;
        _popOverOpen = false;
    }
}
