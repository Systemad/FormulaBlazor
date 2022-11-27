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
    /// <param name="title">Title of Wikipedia page, as in URL</param>
    /// <returns>WikipediaSummary object</returns>
    Task<WikipediaSummary> WikiSummary(string title);
}
