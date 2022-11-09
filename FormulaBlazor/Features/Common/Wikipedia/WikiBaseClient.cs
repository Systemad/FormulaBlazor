using System.Net.Http.Headers;
using System.Text.Json;

namespace FormulaBlazor.Features.Common.Wikipedia;

public static class WikiUrls
{
    // base: https://en.wikipedia.org/api/rest_v1/page/summary/
    public static string WikiBaseUrl => "{0}?redirect=false";
}

public class WikiBaseClient : IWikiBaseClient
{
    private readonly HttpClient _httpClient;

    public WikiBaseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WikipediaSummary> GetDriverSummary(string driver)
    {
        _httpClient.DefaultRequestHeaders.Add(
            "User-Agent",
            "formulablazor/1.0 (https://github.com/Systemad/FormulaBlazor)"
        );
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
        //_httpClient.DefaultRequestHeaders.Add("Api-User-Agent", "formulablazor/1.0");
        var newUrl = string.Format(WikiUrls.WikiBaseUrl, driver);
        //var request = new HttpRequestMessage(new HttpMethod("GET"), newUrl);
        //request.Headers.TryAddWithoutValidation("accept", "application/json; charset=utf-8; profile=\"https://www.mediawiki.org/wiki/Specs/Summary/1.4.2\"");
        try
        {
            var response = await _httpClient.GetStringAsync(newUrl);
            //response.EnsureSuccessStatusCode();
            //var content = await response.Content.ReadAsStringAsync();
            var hey = JsonSerializer.Deserialize<WikipediaSummary>(response);
            return hey;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
