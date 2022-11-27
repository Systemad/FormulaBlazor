using System.Text.Json.Serialization;

namespace FormulaBlazor.Features.Common.Wikipedia;

public class WikipediaSummary
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("displaytitle")]
    public string Displaytitle { get; set; }

    [JsonPropertyName("namespace")]
    public Namespace Namespace { get; set; }

    [JsonPropertyName("wikibase_item")]
    public string WikibaseItem { get; set; }

    [JsonPropertyName("titles")]
    public Titles Titles { get; set; }

    [JsonPropertyName("pageid")]
    public long Pageid { get; set; }

    [JsonPropertyName("thumbnail")]
    public Originalimage Thumbnail { get; set; }

    [JsonPropertyName("originalimage")]
    public Originalimage Originalimage { get; set; }

    [JsonPropertyName("lang")]
    public string Lang { get; set; }

    [JsonPropertyName("dir")]
    public string Dir { get; set; }

    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    [JsonPropertyName("tid")]
    public string Tid { get; set; }

    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("description_source")]
    public string DescriptionSource { get; set; }

    [JsonPropertyName("content_urls")]
    public ContentUrls ContentUrls { get; set; }

    [JsonPropertyName("extract")]
    public string Extract { get; set; }

    [JsonPropertyName("extract_html")]
    public string ExtractHtml { get; set; }
}

public class ContentUrls
{
    [JsonPropertyName("desktop")]
    public Desktop Desktop { get; set; }

    [JsonPropertyName("mobile")]
    public Desktop Mobile { get; set; }
}

public class Desktop
{
    [JsonPropertyName("page")]
    public string Page { get; set; }

    [JsonPropertyName("revisions")]
    public string Revisions { get; set; }

    [JsonPropertyName("edit")]
    public string Edit { get; set; }

    [JsonPropertyName("talk")]
    public string Talk { get; set; }
}

public class Namespace
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}

public class Originalimage
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("width")]
    public long Width { get; set; }

    [JsonPropertyName("height")]
    public long Height { get; set; }
}

public class Titles
{
    [JsonPropertyName("canonical")]
    public string Canonical { get; set; }

    [JsonPropertyName("normalized")]
    public string Normalized { get; set; }

    [JsonPropertyName("display")]
    public string Display { get; set; }
}
