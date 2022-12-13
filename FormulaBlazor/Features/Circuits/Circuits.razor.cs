using FormulaBlazor.Features.Circuits.Models;
using FormulaBlazor.Features.Common.Ergast;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Features.Circuits;

public partial class Circuits
{
    [Inject]
    private IBaseErgastClient _client { get; set; }

    [Inject]
    private NavigationManager _navigation { get; set; }

    private List<CircuitElement>? CircuitList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await InitializeCircuits();
        await base.OnInitializedAsync();
    }

    private async Task InitializeCircuits()
    {
        var data = await _client.GetAsync<CircuitResponse>($"{DateTime.Now.Year}/circuits.json");
        CircuitList = data.MrData.CircuitTable.Circuits;
    }

    private void NavigateToCircuitWikipedia(string circuitId) => _navigation.NavigateTo(circuitId);
}
