using MudBlazor;

namespace FormulaBlazor.Features.Theme;

public class ThemeService
{
    public bool IsDarkMode { get; set; } = false;
    //public EventHandler EventHandler;
    
    public MudTheme Theme { get; set; }

    public void SetDarkMode(bool value)
    {
        IsDarkMode = value;
    }

    public event EventHandler EventHandlerState;
    public void SetTheme(MudTheme theme)
    {
        Theme = theme;
        EventHandlerState?.Invoke(this, EventArgs.Empty);
    }
    public void ToggleDarkMode()
    {
        IsDarkMode = !IsDarkMode;
        EventHandlerState?.Invoke(this, EventArgs.Empty);
    }
}