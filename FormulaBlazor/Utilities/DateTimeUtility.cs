using System.Globalization;

namespace FormulaBlazor.Utilities;

public static class DateTimeUtility
{
    public static string ConvertTimeZone()
    {
        return "timezone";
    }

    // Default Timezone from Ergast is UTC, so client passes timezone for which should be converted to
    public static DateTime ParseDateTime(string fromTime, string toTimeZone)
    {
        var from = DateTime.Parse(fromTime);
        var local = from.ToLocalTime();
        return local;
    }
}
