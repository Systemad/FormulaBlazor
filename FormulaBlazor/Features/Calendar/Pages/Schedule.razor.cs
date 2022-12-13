using System.Text.Json;
using FormulaBlazor.Features.Calendar.Models;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Utilities;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Calendar.Pages;

public partial class Schedule
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    [Inject]
    private NavigationManager NavigationManager { get; set; }
    private ScheduleDto? RaceTable { get; set; }
    private List<int> SeasonList { get; set; }
    private int SelectSeason { get; set; } = DateTime.Now.Year;

    protected override async Task OnInitializedAsync()
    {
        SeasonList = SeasonHelper.GetSeasons();
        await InitializeCalendarAsync();
        await base.OnInitializedAsync();
    }

    private async Task FetchScheduleForSeason(int year)
    {
        var data = await _client.GetAsync<CalendarResponse>($"{year}.json");
        var oldStand = data.MrData.RaceTable;
        RaceTable = oldStand.MapScheduleDto();
        StateHasChanged();
    }

    private async Task InitializeCalendarAsync()
    {
        //await FetchScheduleForSeason(SelectSeason);
        string text = await File.ReadAllTextAsync(
            "C:\\Users\\yeahg\\RiderProjects\\FormulaBlazor\\FormulaBlazor\\Resources\\schedule.json"
        );
        var textSeriialize = JsonSerializer.Deserialize<CalendarResponse>(text);
        var oldStand = textSeriialize.MrData.RaceTable;
        RaceTable = oldStand.MapScheduleDto();
    }

    private void NavigateToResult(string year, string round)
    {
        NavigationManager.NavigateTo($"result/{year}/{round}");
    }

    private string GetSelectionText(int selection)
    {
        var now = DateTime.Now.Year;
        return selection == now ? $"Current season" : selection.ToString();
    }

    private async Task OnSelectSeasonChanged(int season)
    {
        Console.WriteLine("Season: " + season);
        SelectSeason = season;
        await FetchScheduleForSeason(season);
    }
}
