namespace Tavstal.PayPalSDK.Tests.Mocks;

/// <summary>
/// A simple <see cref="HttpMessageHandler"/> implementation used in tests to route outgoing
/// <see cref="HttpRequestMessage"/> instances to a user-provided responder delegate.
/// </summary>
public class HttpMessageMockHandler : HttpMessageHandler
{
    private readonly Func<HttpRequestMessage, HttpResponseMessage> _responder;

    /// <summary>
    /// Initializes a new instance of <see cref="HttpMessageMockHandler"/>.
    /// </summary>
    /// <param name="responder">A delegate that will be called whenever the handler receives an <see cref="HttpRequestMessage"/>.</param>
    public HttpMessageMockHandler(Func<HttpRequestMessage, HttpResponseMessage> responder)
    {
        _responder = responder;
    }

    
    /// <summary>
    /// Sends the HTTP request by invoking the responder delegate and returning its result as a
    /// completed <see cref="Task{HttpResponseMessage}"/>.
    /// </summary>
    /// <param name="request">The outgoing HTTP request that would have been sent to the server.</param>
    /// <param name="cancellationToken">The cancellation token from <see cref="HttpClient"/>.</param>
    /// <returns>
    /// A completed <see cref="Task{HttpResponseMessage}"/> containing the <see cref="HttpResponseMessage"/>
    /// returned by the responder delegate.
    /// </returns>
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_responder(request));
    }
}