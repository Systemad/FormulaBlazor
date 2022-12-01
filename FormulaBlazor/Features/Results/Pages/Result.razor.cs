using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Results.Models;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Results.Pages;

public partial class Result
{
    [Inject]
    private IBaseErgastClient Client { get; set; }
    private RaceTable RaceTable { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //await InitializeResultAsync();
        await base.OnInitializedAsync();
    }

    [Parameter]
    public string? Year { get; set; }

    [Parameter]
    public string? Round { get; set; }

    private async Task InitializeResultAsync()
    {
        var data = await Client.GetAsync<Models.Results>($"/{Year}/{Round}/results");
        var result = data.MrData.RaceTable;
        RaceTable = result;
    }
}
