namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents a PayPal HTTP client capable of sending requests to the PayPal API.
/// </summary>
public interface IPayPalHttpClient
{
    /// <summary>
    /// Sends an HTTP request to the PayPal API.
    /// </summary>
    /// <param name="request">The HTTP request to send.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation, containing the HTTP response.</returns>
    Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default);
}