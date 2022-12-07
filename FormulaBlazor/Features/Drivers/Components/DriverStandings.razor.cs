using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Common.Wikipedia;
using FormulaBlazor.Features.Drivers.DTO;
using FormulaBlazor.Features.Drivers.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaBlazor.Features.Drivers.Components;

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
    private DriverDto? _selectedDriver = null;

    private int SelectedSeason { get; set; } = DateTime.UtcNow.Year;

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
        _loading = false;
        await FetchSeason(SelectedSeason);
    }

    private async Task FetchSeason(int season)
    {
        var data = await _client.GetAsync<DriverStandingsRoot>(
            $"{SelectedSeason}/driverStandings.json"
        );
        var oldStand = data.MrData.StandingsTable.StandingsLists[0];
        _driverStanding = oldStand.MapToDriverList();
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

    private async Task OnSelectSeasonChanged(int season)
    {
        Console.WriteLine("Season: " + season);
        SelectedSeason = season;
        await FetchSeason(season);
    }
}
