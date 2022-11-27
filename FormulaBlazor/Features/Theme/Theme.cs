using MudBlazor;

namespace FormulaBlazor.Features.Theme;

public static class Theme
{
    public static MudTheme MainTheme()
    {
        var theme = new MudTheme
        {
            /*
            Palette = LightPalette,
            PaletteDark = DarkPalette,
            Shadows = Shadow,
            Typography = Typography,
            LayoutProperties = LayoutProperties,
            ZIndex = new ZIndex()
            */
        };

        return theme;
    }

    private static readonly Palette LightPalette =
        new()
        {
            //Primary = Colors.Blue.Accent1,
            //Background = "#f8fafd",
            //Secondary = "#f3f6fc"
            //AppbarBackground = Color.Transparent,
            //AppbarBackground =
        };

    private static readonly Palette DarkPalette =
        new()
        {
            //Primary = Colors.Blue.Darken1,
            //Background = "#1f1f1f",
            //Dark = "#2d2f31",
            //Secondary = "#2d2f31",
            //AppbarBackground = Color.Transparent,
            //AppbarBackground =
        };

    private static readonly Shadow Shadow = new() { };

    private static readonly Typography Typography = new() { };

    private static readonly LayoutProperties LayoutProperties = new() { };
}
