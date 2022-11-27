using MudBlazor;

namespace FormulaBlazor.Features.Theme;

public class ThemeService
{
    public bool IsDarkMode { get; set; } = false;

    public MudTheme Theme { get; set; }

    public void SetDarkMode(bool value)
    {
        IsDarkMode = value;
    }

    public event EventHandler MajorUpdateOccured;

    private void OnMajorUpdateOccured() => MajorUpdateOccured?.Invoke(this, EventArgs.Empty);

    public void SetTheme(MudTheme theme)
    {
        Theme = theme;
        OnMajorUpdateOccured();
    }

    public void ToggleDarkMode()
    {
        IsDarkMode = !IsDarkMode;
        OnMajorUpdateOccured();
    }
}
