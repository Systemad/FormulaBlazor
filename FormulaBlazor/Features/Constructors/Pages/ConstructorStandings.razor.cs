using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Common.Wikipedia;
using FormulaBlazor.Features.Constructors.Models;
using FormulaBlazor.Features.Drivers.DTO;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaBlazor.Features.Constructors.Pages;

public partial class ConstructorStandings
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    [Inject]
    private NavigationManager _navigation { get; set; }

    [Inject]
    private IWikiBaseClient _wikiBaseClient { get; set; }

    private ConstructorStandingsList? _constructorStanding = new();
    private MudTable<ConstructorStanding> mudTable;
    private int selectedRowNumber = -1;
    private DriverDto? _selectedDriver;

    //private bool driverSelected = _selectedDriver == null;

    private bool _popOverOpen = false;
    private bool _hidePosition;
    private bool _loading;
    private int SelectedSeason { get; set; } = DateTime.UtcNow.Year;

    protected override async Task OnInitializedAsync()
    {
        await InitializeConstructorStandings();
        await base.OnInitializedAsync();
    }

    private async Task InitializeConstructorStandings()
    {
        _loading = true;
        _selectedDriver = null;
        await FetchSeason(SelectedSeason);
        _loading = false;
    }

    private async Task FetchSeason(int season)
    {
        var data = await _client.GetAsync<ConstructorStandingResponse>(
            $"{season}/constructorStandings.json"
        );
        var oldStand = data.MrData.StandingsTable.StandingsLists[0];
        _constructorStanding = oldStand;
        //StateHasChanged();
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
        SelectedSeason = season;
        await FetchSeason(season);
    }
}
