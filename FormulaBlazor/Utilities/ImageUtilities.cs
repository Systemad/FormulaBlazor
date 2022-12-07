namespace FormulaBlazor.Utilities;

public class ImageUtilities
{
    private static string _driverBasePath = "images/drivers";

    public static string GetDriverImage(string driver)
    {
        if (!driver.Any(char.IsWhiteSpace))
            return driver + ".png";
        var source = driver.Replace(" ", "_");
        return _driverBasePath + source + ".png";
    }
}
