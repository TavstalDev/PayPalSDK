using System.Net;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Configuration options for <see cref="PayPalHttpClient"/>.
/// All properties are optional with sensible defaults.
/// </summary>
[FluentApi]
public class PayPalClientOptions
{
    /// <summary>
    /// An optional refresh token for obtaining access tokens.
    /// When set, the client uses <c>grant_type=refresh_token</c> instead of <c>client_credentials</c>.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    public string? RefreshToken { get; set; }
    
    /// <summary>
    /// An optional application name included in the <c>User-Agent</c> header.
    /// Defaults to <c>"Tavstal/PayPalSDK"</c> when omitted.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    public string? ApplicationName { get; set; }
    
    /// <summary>
    /// The HTTP request timeout applied to every API call.
    /// Includes the time to acquire a connection, send the request, and receive the response headers.
    /// Defaults to 120 seconds.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(120);
    
    /// <summary>
    /// The maximum number of bytes to buffer for the response content.
    /// Responses larger than this threshold trigger an <see cref="InvalidOperationException"/>.
    /// Defaults to 2 MB.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    public long MaxResponseContentBufferSize { get; set; } = 1024 * 1024 * 2;
    
    /// <summary>
    /// The maximum number of concurrent HTTP connections allowed per remote server.
    /// Controls connection pooling; higher values reduce latency under high concurrency.
    /// Defaults to 10.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    public int MaxConnectionsPerServer { get; set; } = 10;

    /// <summary>
    /// The maximum number of retry attempts for transient failures.
    /// Retries apply to <see cref="HttpRequestException"/> (network-level errors),
    /// HTTP 429 (rate limit), and HTTP 5xx (server errors).
    /// Set to 0 to disable retries entirely. Defaults to 3.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    public int MaxRetries { get; set; } = 3; 
    
    /// <summary>
    /// The base delay between retry attempts.
    /// Each subsequent retry doubles this value (exponential backoff).
    /// The actual delay includes random jitter of up to one second to avoid thundering-herd effects.
    /// Defaults to 1 second.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    public TimeSpan RetryDelay { get; set; } = TimeSpan.FromSeconds(1);
    
    /// <summary>
    /// When <c>true</c>, the client automatically decompresses GZip and Deflate responses
    /// and adds the <c>Accept-Encoding: gzip</c> request header.
    /// When <c>false</c>, all responses are received uncompressed.
    /// Defaults to <c>true</c>.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    public bool EnableCompression { get; set; } = true;
    
    /// <summary>
    /// When <c>true</c>, HTTP 429 (Too Many Requests) responses are retried up to <see cref="MaxRetries"/> times.
    /// The 429 response's <c>Retry-After</c> header takes precedence over <see cref="RetryDelay"/> when present.
    /// HTTP 5xx errors are always retried regardless of this setting.
    /// Defaults to <c>true</c>.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    public bool RetryOnRateLimit { get; set; } = true;
    
    /// <summary>
    /// An optional web proxy used for all outgoing HTTP requests.
    /// When <c>null</c>, the system default proxy is used.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    public IWebProxy? Proxy { get; set; }
    
    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(10, "Build")]
    public void Build() { }
}