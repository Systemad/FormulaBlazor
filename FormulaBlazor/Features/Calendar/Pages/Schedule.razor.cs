using System.Text.Json;
using FormulaBlazor.Features.Calendar.Models;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Utilities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace FormulaBlazor.Features.Calendar.Pages;

public partial class Schedule
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    [Inject]
    private IJSRuntime JS { get; set; }

    private ScheduleDto? RaceTable { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await InitializeCalendarAsync();
        await base.OnInitializedAsync();
    }

    private async Task InitializeCalendarAsync()
    {
        //var data = await _client.GetAsync<Response<MrData>>("current.json");
        //var oldStand = data.Root.RaceTable;

        string text = await File.ReadAllTextAsync(
            "C:\\Users\\yeahg\\RiderProjects\\FormulaBlazor\\FormulaBlazor\\Resources\\schedule.json"
        );
        var textSeriialize = JsonSerializer.Deserialize<Response<MrData>>(text);
        var oldStand = textSeriialize.Root.RaceTable;

        //var hey = oldStand.MapScheduleDto();
        RaceTable = oldStand.MapScheduleDto();
    }
}
