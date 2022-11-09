using System.Text.Json;

namespace FormulaBlazor.Features.Common.Ergast;

public class BaseErgastClient : IBaseErgastClient
{
    private readonly HttpClient _httpClient;

    public BaseErgastClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> GetAsync<T>(string url)
    {
        try
        {
            var response = await _httpClient.GetStringAsync(url);
            var hey = JsonSerializer.Deserialize<T>(response);
            return hey;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
