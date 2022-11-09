namespace FormulaBlazor.Features.Common.Ergast;

public class FixUrlJsonHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.RequestUri = new Uri(request.RequestUri.AbsoluteUri + "json");
        return await base.SendAsync(request, cancellationToken);
    }
}