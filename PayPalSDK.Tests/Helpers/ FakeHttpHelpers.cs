using System.Net.Http.Json;
using System.Text.Json.Serialization.Metadata;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Serialization;
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
    
    /// <summary>
    /// Reads and deserializes the HTTP content using the SDK's source-generated JSON context.
    /// </summary>
    /// <typeparam name="T">The type to deserialize the response body into.</typeparam>
    /// <param name="content">The HTTP content containing JSON payload data.</param>
    /// <returns>A task that produces the deserialized instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when <typeparamref name="T"/> is not registered in <see cref="PayPalSDKJsonContext"/>.
    /// </exception>
    public static Task<T?> ReadJsonAsync<T>(this HttpContent content)
    {
        var typeInfo = (JsonTypeInfo<T>?)PayPalSDKJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return content.ReadFromJsonAsync(typeInfo);
    }
}