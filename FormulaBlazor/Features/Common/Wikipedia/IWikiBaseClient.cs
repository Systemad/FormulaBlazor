namespace FormulaBlazor.Features.Common.Wikipedia;

/// <summary>
///  Simple Wikipedia HTTPClient to fetch minimal information
/// </summary>
public interface IWikiBaseClient
{
    /// <summary>
    /// PARAM: PAGE TITLE
    /// Fetch summary of Wikipedia page
    /// OBS: Case sensitive!!!
    /// </summary>
    /// <param name="driver"></param>
    /// <returns>WikipediaSummary object</returns>
    Task<WikipediaSummary> GetDriverSummary(string driver);
}
