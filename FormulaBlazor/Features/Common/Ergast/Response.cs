using System.Text.Json.Serialization;
using FormulaBlazor.Features.Common.Ergast.Responses;

namespace FormulaBlazor.Features.Common.Ergast;

public class Response<T> where T : MrDataRoot
{
    [JsonPropertyName("MRData")]
    public T Root { get; set; }
}
