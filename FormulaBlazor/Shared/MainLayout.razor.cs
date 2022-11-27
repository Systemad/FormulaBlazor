using FormulaBlazor.Features.Theme;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaBlazor.Shared;

public partial class MainLayout : LayoutComponentBase
{
    [Inject]
    private ThemeService _themeService { get; set; }

    protected override void OnInitialized()
    {
        _themeService.SetTheme(Theme.MainTheme());
        _themeService.MajorUpdateOccured += LayoutServiceOnMajorUpdateOccured;
        base.OnInitialized();
    }

    private void LayoutServiceOnMajorUpdateOccured(object sender, EventArgs e) => StateHasChanged();
}
