namespace FormulaBlazor.Utilities;

public static class SeasonHelper
{
    public static List<int> GetSeasons()
    {
        var seasons = new List<int>();
        for (var i = DateTime.Now.Year; i >= 1950; i--)
        {
            seasons.Add(i);
        }
        return seasons;
    }
}
