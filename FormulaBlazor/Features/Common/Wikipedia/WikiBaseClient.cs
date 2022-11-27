using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;

namespace FormulaBlazor.Features.Common.Wikipedia;

public static class WikiUrls
{
    // base: https://en.wikipedia.org/api/rest_v1/page/summary/
    public static string WikiBaseUrl => "{0}?redirect=false";
}

public class WikiBaseClient : IWikiBaseClient
{
    private readonly IMemoryCache _memoryCache;
    private readonly HttpClient _httpClient;

    public WikiBaseClient(HttpClient httpClient, IMemoryCache memoryCache)
    {
        _httpClient = httpClient;
        _memoryCache = memoryCache;
    }

    public async Task<WikipediaSummary> WikiSummary(string title)
    {
        if (_memoryCache.TryGetValue(title, out WikipediaSummary rsp))
        {
            return rsp;
        }

        _httpClient.DefaultRequestHeaders.Add(
            "User-Agent",
            "formulablazor/1.0 (https://github.com/Systemad/FormulaBlazor)"
        );
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
        var newUrl = string.Format(WikiUrls.WikiBaseUrl, title);
        try
        {
            var response = await _httpClient.GetStringAsync(newUrl);
            var responseSerialized = JsonSerializer.Deserialize<WikipediaSummary>(response);

            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(
                TimeSpan.FromMinutes(5)
            );
            _memoryCache.Set(title, responseSerialized, cacheEntryOptions);

            return responseSerialized;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
