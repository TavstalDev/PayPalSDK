using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Tests.Mocks;

namespace Tavstal.PayPalSDK.Tests.Helpers;

/// <summary>
/// Factory helper for creating test-ready <see cref="PayPalHttpClient"/> instances.
/// </summary>
public static class FakeHttpHelpers
{
    /// <summary>
    /// Create a test instance of <see cref="PayPalHttpClient"/> that routes HTTP requests to a
    /// custom responder delegate.
    /// </summary>
    /// <param name="responder">
    /// A synchronous delegate that receives the outgoing <see cref="HttpRequestMessage"/> and
    /// returns a prepared <see cref="HttpResponseMessage"/>. The delegate is invoked by a
    /// test <see cref="HttpMessageHandler"/> implementation (<see cref="HttpMessageMockHandler"/>).
    /// </param>
    /// <returns>
    /// A <see cref="PayPalHttpClient"/> instance configured to use an <see cref="HttpClient"/>
    /// backed by the test handler. The returned client is safe to use in unit and contract tests
    /// and will not perform real network calls.
    /// </returns>
    public static PayPalHttpClient CreateClient(Func<HttpRequestMessage, HttpResponseMessage> responder)
    {
        var env = new SandboxEnvironment("fake-client-id", "fake-client-secret");
        var handler = new HttpMessageMockHandler(responder);
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(env.BaseUrl)
        };
        var clientWithInjectedHttp = new PayPalHttpClient(env, httpClient);
        return clientWithInjectedHttp;
    }
}