namespace FormulaBlazor.Utilities;

public enum ImageType
{
    Driver,
    Countries,
    Circuits,
    Logos
}

public static class ImageUtilities
{
    private static string _driverBasePath = "images/drivers";
    private static string _countriesBasePath = "images/countries";
    private static string _circuitsBasePath = "images/circuits";
    private static string _logosBasePath = "images/logos";

    public static string GetImageSource(ImageType type, string fileName)
    {
        string path = type switch
        {
            ImageType.Circuits => $"{_circuitsBasePath}/{fileName}.png",
            ImageType.Countries => $"{_countriesBasePath}/{fileName}.png",
            ImageType.Logos => $"{_logosBasePath}/{fileName}.png",
            ImageType.Driver => $"{_driverBasePath}/{fileName}.png",
            _ => string.Empty
        };
        return path;
    }

    public static string GetDriverImage(string driver)
    {
        if (!driver.Any(char.IsWhiteSpace))
            return driver + ".png";
        var source = driver.Replace(" ", "_");
        return _driverBasePath + source + ".png";
    }
}
