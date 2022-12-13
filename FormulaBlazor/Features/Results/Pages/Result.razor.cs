using FormulaBlazor.Features.Common.Ergast;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Results.Pages;

public partial class Result
{
    [Inject]
    private IBaseErgastClient Client { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
    }

    [Parameter]
    public string? Year { get; set; }

    [Parameter]
    public string? Round { get; set; }
}
