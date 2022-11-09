namespace FormulaBlazor.Features.Common.Ergast;

/// <summary>
/// Minimal Ergast HTTPClient to fetch specific endpoints
/// </summary>
public interface IBaseErgastClient
{
    /// <summary>
    /// Fetch Ergast API. You only need to provide endpoint.json as URL
    /// and the model such as '_client.GetAsync object ("current/driverStandings.json")'
    /// </summary>
    /// <param name="url">endpoints</param>
    /// <typeparam name="T">Model to fetch</typeparam>
    /// <returns>Method automatically deserializes json to model, so just provide the model of whatever information you want to fetch</returns>
    Task<T> GetAsync<T>(string url);
}
