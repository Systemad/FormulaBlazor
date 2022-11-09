using MudBlazor;

namespace FormulaBlazor.Features.Theme;

public static class Theme
{
    public static MudTheme MainTheme()
    {
        var theme = new MudTheme
        {
            Palette = LightPalette,
            PaletteDark = DarkPalette,
            Shadows = Shadow,
            Typography = Typography,
            LayoutProperties = LayoutProperties,
            ZIndex = new ZIndex()
        };

        return theme;
    }

    private static readonly Palette LightPalette = new()
    {
        Primary = Colors.Blue.Accent1,
        Dark = Colors.Grey.Darken3
        //AppbarBackground = 
    };

    private static readonly Palette DarkPalette = new()
    {

    };

    private static readonly Shadow Shadow = new()
    {

    };
    
    private static readonly Typography Typography = new()
    {

    };
    
    private static readonly LayoutProperties LayoutProperties = new()
    {
    };
}