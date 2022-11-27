using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;

namespace FormulaBlazor.Features.Common.Ergast;

/* Add Caching
 *  Dictionary<string, MrData> CacheString = new() |||| USE IMEMORYCACHE
 *  https://learn.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-7.0
 *  in GetAsync, look up string in Dictionary, if it exist, just return object
 *  if it doesn't exist, fetch and create new entry in Dictionary
 */
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
