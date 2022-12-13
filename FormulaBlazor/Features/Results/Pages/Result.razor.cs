using System.Text.Json;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Results.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Results.Pages;

public partial class Result
{
    [Inject]
    private IBaseErgastClient Client { get; set; }
    private QualifyingRaceTable? QualifyingRaceTable { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        await InitializeDataAsync();
        await base.OnParametersSetAsync();
    }

    [Parameter]
    public string? Year { get; set; }

    [Parameter]
    public string? Round { get; set; }

    private async Task InitializeDataAsync()
    {
        string text = await File.ReadAllTextAsync(
            "C:\\Users\\yeahg\\RiderProjects\\FormulaBlazor\\FormulaBlazor\\Resources\\qualdata.json"
        );
        // Race results
        //var data = await Client.GetAsync<ResultsRoot>($"{Year}/{Round}/results.json");
        //var result = data.MrData.RaceTable;
        //RaceTable = result;

        // Qualifying results
        //var dataQual = await Client.GetAsync<QualifyingResponse>($"{Year}/{Round}/qualifying.json");
        var textSeriialize = JsonSerializer.Deserialize<QualifyingResponse>(text);
        var resultQual = textSeriialize.MrData.RaceTable;
        QualifyingRaceTable = resultQual;
    }
}
