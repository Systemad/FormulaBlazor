using FormulaBlazor.Features.Theme;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FormulaBlazor.Shared;

public partial class MainLayout : LayoutComponentBase
{
    [Inject] private ThemeService _themeService { get; set; }

    protected override Task OnInitializedAsync()
    {
        _themeService.SetTheme(Theme.MainTheme());
        return base.OnInitializedAsync();
    }
}