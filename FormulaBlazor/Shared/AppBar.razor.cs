using FormulaBlazor.Features.Theme;
using Microsoft.AspNetCore.Components;

namespace FormulaBlazor.Shared;

public partial class AppBar
{
    [Inject] private ThemeService _themeService { get; set; }
    
    private void ToggleTheme()
    {
        _themeService.ToggleDarkMode();
        StateHasChanged();
    }
}