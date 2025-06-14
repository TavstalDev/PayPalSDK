namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents the base class for HTTP requests in the Tavstal PayPal SDK.
/// </summary>
public abstract class HttpRequestBase : HttpRequestMessage
{
    /// <summary>
    /// The type of the expected response for the HTTP request.
    /// </summary>
    protected Type _responseType;

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpRequestBase"/> class.
    /// </summary>
    /// <param name="method">The HTTP method to be used for the request (e.g., GET, POST).</param>
    /// <param name="url">The URL to which the request will be sent.</param>
    /// <param name="responseType">The type of the expected response.</param>
    protected HttpRequestBase(HttpMethod method, string url, Type responseType)
    {
        this.Method = method;
        this.RequestUri = new Uri(url);
        _responseType = responseType;
    }
}