using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;

namespace FormulaBlazor.Features.Common.Ergast;

public class BaseErgastClient : IBaseErgastClient
{
    private readonly IMemoryCache _memoryCache;
    private readonly HttpClient _httpClient;

    public BaseErgastClient(HttpClient httpClient, IMemoryCache memoryCache)
    {
        _httpClient = httpClient;
        _memoryCache = memoryCache;
    }

    public async Task<T> GetAsync<T>(string url)
    {
        if (_memoryCache.TryGetValue(url, out T rsp))
        {
            return rsp;
        }

        try
        {
            var response = await _httpClient.GetStringAsync(url);
            var responseSerialized = JsonSerializer.Deserialize<T>(response);
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(
                TimeSpan.FromMinutes(5)
            );
            _memoryCache.Set(url, responseSerialized, cacheEntryOptions);
            return responseSerialized;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
