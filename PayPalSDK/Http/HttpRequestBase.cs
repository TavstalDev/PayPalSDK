using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents the base class for HTTP requests in the PayPal SDK.
/// </summary>
public abstract class HttpRequestBase : HttpRequestMessage
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HttpRequestBase"/> class.
    /// </summary>
    /// <param name="method">The HTTP method to be used for the request (e.g., GET, POST).</param>
    /// <param name="url">The URL to which the request will be sent.</param>
    protected HttpRequestBase(HttpMethod method, string url)
    {
        Method = method;
        RequestUri = new Uri(url, UriKind.Relative);
    }
}

/// <summary>
/// Represents a generic base class for HTTP requests in the PayPal SDK.
/// </summary>
/// <typeparam name="T">The type of the expected response.</typeparam>
public abstract class HttpRequestBase<T> : HttpRequestBase where T : class
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HttpRequestBase{T}"/> class.
    /// </summary>
    /// <param name="method">The HTTP method to be used for the request (e.g., GET, POST).</param>
    /// <param name="url">The URL to which the request will be sent.</param>
    protected HttpRequestBase(HttpMethod method, string url)
        : base(method, url) { }
    
    /// <summary>
    /// Asynchronously reads and deserializes the response body into <typeparamref name="T"/> using
    /// the SDK's source-generated <see cref="PayPalSDKJsonContext"/>.
    /// </summary>
    /// <param name="response">The HTTP response message whose content will be deserialized.</param>
    /// <returns>
    /// A task that resolves to the deserialized instance of <typeparamref name="T"/>,
    /// or <c>null</c> if the content is empty.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when <typeparamref name="T"/> is not registered in <see cref="PayPalSDKJsonContext"/>.
    /// </exception>
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response)
    {
        var typeInfo = (JsonTypeInfo<T>?)PayPalSDKJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return await response.Content.ReadFromJsonAsync(typeInfo);
    }
    
    
    /// <summary>
    /// Asynchronously reads and deserializes the response body into <typeparamref name="T"/> using
    /// a caller-supplied <see cref="JsonTypeInfo{T}"/>.
    /// </summary>
    /// <param name="response">The HTTP response message whose content will be deserialized.</param>
    /// <param name="jsonTypeInfo">
    /// The <see cref="JsonTypeInfo{T}"/> that controls deserialization. Use this overload when
    /// you need to supply a type info from a context other than <see cref="PayPalSDKJsonContext"/>.
    /// </param>
    /// <returns>
    /// A task that resolves to the deserialized instance of <typeparamref name="T"/>,
    /// or <c>null</c> if the content is empty.
    /// </returns>
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response, JsonTypeInfo<T> jsonTypeInfo) => await response.Content.ReadFromJsonAsync(jsonTypeInfo);
}