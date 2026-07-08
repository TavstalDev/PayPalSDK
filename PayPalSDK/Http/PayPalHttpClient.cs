using System.Net;
using System.Net.Http.Headers;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http.Clients;
using Tavstal.PayPalSDK.Models.Auth;
using Tavstal.PayPalSDK.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents a PayPal HTTP client for sending requests to the PayPal API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public sealed class PayPalHttpClient : IPayPalHttpClient, IDisposable
{
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private HttpClient _httpClient;
    private AccessToken? _accessToken;
    private string? _refreshToken;
    
    [FluentMember(0, "WithEnvironment")]
    private EnvironmentBase _environment;

    /// <summary>
    /// Configures the client to use the PayPal sandbox environment for testing.
    /// </summary>
    /// <param name="clientId">The PayPal sandbox application client ID.</param>
    /// <param name="clientSecret">The PayPal sandbox application client secret.</param>
    [FluentMethod(0, "WithSandboxEnvironment")]
    public void WithSandboxEnvironment(string clientId, string clientSecret)
    {
        _environment = new SandboxEnvironment(clientId, clientSecret);
    }
    
    /// <summary>
    /// Configures the client to use the PayPal live (production) environment.
    /// </summary>
    /// <param name="clientId">The PayPal live application client ID.</param>
    /// <param name="clientSecret">The PayPal live application client secret.</param>
    [FluentMethod(0, "WithLiveEnvironment")]
    public void WithLiveEnvironment(string clientId, string clientSecret)
    {
        _environment = new LiveEnvironment(clientId, clientSecret);
    }
    
    [FluentMember(1, "WithOptions")]
    [FluentSkippable]
    private PayPalClientOptions _options;
    
    /// <summary>
    /// Provides operations for retrieving and converting currency exchange rates.
    /// </summary>
    public CurrencyExchangeClient CurrencyExchange { get; private set; }

    /// <summary>
    /// Provides operations for managing and responding to customer disputes.
    /// </summary>
    public DisputesClient Disputes { get; private set; }

    /// <summary>
    /// Provides operations for creating, sending, and managing invoices.
    /// </summary>
    public InvoicesClient Invoices { get; private set; }

    /// <summary>
    /// Provides operations for creating, capturing, authorizing, and retrieving orders.
    /// </summary>
    public OrdersClient Orders { get; private set; }

    /// <summary>
    /// Provides operations for creating and managing vaulted payment method tokens.
    /// </summary>
    public PaymentMethodTokensClient PaymentMethodTokens { get; private set; }

    /// <summary>
    /// Provides operations for working with payment resources, such as captures, authorizations, and refunds.
    /// </summary>
    public PaymentResourcesClient PaymentResources { get; private set; }

    /// <summary>
    /// Provides operations for creating and managing direct payment transactions.
    /// </summary>
    public PaymentsClient Payments { get; private set; }

    /// <summary>
    /// Provides operations for managing product catalog entries.
    /// </summary>
    public ProductCatalogClient ProductCatalog { get; private set; }

    /// <summary>
    /// Provides operations for creating and managing subscription plans and agreements.
    /// </summary>
    public SubscriptionsClient Subscriptions { get; private set; }

    /// <summary>
    /// Provides operations for creating and updating shipment tracking information.
    /// </summary>
    public TrackingClient Tracking { get; private set; }

    /// <summary>
    /// Provides operations for querying historical transaction activity.
    /// </summary>
    public TransactionSearchClient TransactionSearch { get; private set; }

    /// <summary>
    /// Provides operations for managing webhooks and event subscriptions.
    /// </summary>
    public WebhooksClient Webhooks { get; private set; }

    // Used by the M31.FluentApi generated builder.
    // ReSharper disable once UnusedMember.Local
    private PayPalHttpClient()
    {
        _httpClient = null!;
        _environment = null!;
        _options = null!;
        _refreshToken = null;
        CurrencyExchange = null!;
        Disputes = null!;
        Invoices = null!;
        Orders = null!;
        PaymentMethodTokens = null!;
        PaymentResources = null!;
        Payments = null!;
        ProductCatalog = null!;
        Subscriptions = null!;
        Tracking = null!;
        TransactionSearch = null!;
        Webhooks = null!;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PayPalHttpClient"/> class with the specified environment and optional client options.
    /// </summary>
    /// <param name="environment">The environment configuration.</param>
    /// <param name="options">Optional client options for configuration.</param>
    public PayPalHttpClient(EnvironmentBase environment, PayPalClientOptions? options = null)
        : this(environment, new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = (options ?? new PayPalClientOptions()).EnableCompression
                ? DecompressionMethods.GZip | DecompressionMethods.Deflate
                : DecompressionMethods.None,
            MaxConnectionsPerServer = (options ?? new PayPalClientOptions()).MaxConnectionsPerServer,
            Proxy = (options ?? new PayPalClientOptions()).Proxy
        }), options)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PayPalHttpClient"/> class with a pre-configured HttpClient (for testing).
    /// </summary>
    /// <param name="environment">The environment configuration.</param>
    /// <param name="httpClient">The pre-configured HttpClient instance (e.g. with a mock handler).</param>
    /// <param name="options">Optional client options for configuration.</param>
    internal PayPalHttpClient(EnvironmentBase environment, HttpClient httpClient, PayPalClientOptions? options = null)
    {
        _httpClient = httpClient;
        _options = options ?? new PayPalClientOptions();
        _environment = environment;
        _refreshToken = _options.RefreshToken;
        _httpClient.MaxResponseContentBufferSize = _options.MaxResponseContentBufferSize;
        _httpClient.Timeout = _options.Timeout;

        // Ensure BaseAddress and some default headers exist when not already set on the supplied HttpClient.
        if (_httpClient.BaseAddress == null)
            _httpClient.BaseAddress = new Uri(_environment.BaseUrl);

        if (!_httpClient.DefaultRequestHeaders.Contains("Accept"))
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        
        if (_options.EnableCompression)
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

        if (!_httpClient.DefaultRequestHeaders.UserAgent.Any())
        {
            var agent = _options.ApplicationName != null ? UserAgent.GetUserAgentHeader(_options.ApplicationName) : UserAgent.GetUserAgentHeader();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(agent);
        }

        CurrencyExchange = new CurrencyExchangeClient(this);
        Disputes = new DisputesClient(this);
        Invoices = new InvoicesClient(this);
        Orders = new OrdersClient(this);
        PaymentMethodTokens = new PaymentMethodTokensClient(this);
        PaymentResources = new PaymentResourcesClient(this);
        Payments = new PaymentsClient(this);
        ProductCatalog = new ProductCatalogClient(this);
        Subscriptions = new SubscriptionsClient(this);
        Tracking = new TrackingClient(this);
        TransactionSearch = new TransactionSearchClient(this);
        Webhooks = new WebhooksClient(this);
    }

    /// <summary>
    /// Initializes the internal <see cref="HttpClient"/>, request headers, and all domain-specific client instances.
    /// Used by the public constructor, the internal test-only constructor, and the M31.FluentApi <see cref="Build"/> method.
    /// </summary>
    /// <param name="environment">The PayPal environment (sandbox or live).</param>
    /// <param name="httpClient">The pre-configured <see cref="System.Net.Http.HttpClient"/> instance.</param>
    /// <param name="options">Optional client options; defaults are applied when <c>null</c>.</param>
    private void Initialize(EnvironmentBase environment, HttpClient httpClient, PayPalClientOptions? options)
    {
        _httpClient = httpClient;
        _options = options ?? new PayPalClientOptions();
        _environment = environment;
        _refreshToken = _options.RefreshToken;
        _httpClient.MaxResponseContentBufferSize = _options.MaxResponseContentBufferSize;
        _httpClient.Timeout = _options.Timeout;

        // Ensure BaseAddress and some default headers exist when not already set on the supplied HttpClient.
        if (_httpClient.BaseAddress == null)
            _httpClient.BaseAddress = new Uri(_environment.BaseUrl);

        if (!_httpClient.DefaultRequestHeaders.Contains("Accept"))
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        
        if (_options.EnableCompression)
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

        if (!_httpClient.DefaultRequestHeaders.UserAgent.Any())
        {
            var agent = _options.ApplicationName != null ? UserAgent.GetUserAgentHeader(_options.ApplicationName) : UserAgent.GetUserAgentHeader();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(agent);
        }

        CurrencyExchange = new CurrencyExchangeClient(this);
        Disputes = new DisputesClient(this);
        Invoices = new InvoicesClient(this);
        Orders = new OrdersClient(this);
        PaymentMethodTokens = new PaymentMethodTokensClient(this);
        PaymentResources = new PaymentResourcesClient(this);
        Payments = new PaymentsClient(this);
        ProductCatalog = new ProductCatalogClient(this);
        Subscriptions = new SubscriptionsClient(this);
        Tracking = new TrackingClient(this);
        TransactionSearch = new TransactionSearchClient(this);
        Webhooks = new WebhooksClient(this);
    }

    /// <summary>
    /// Terminal builder method called by the generated M31.FluentApi builder.
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build()
    {
        // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
        var opts = _options ?? new PayPalClientOptions();
        var client = new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = opts.EnableCompression
                ? DecompressionMethods.GZip | DecompressionMethods.Deflate
                : DecompressionMethods.None,
            MaxConnectionsPerServer = opts.MaxConnectionsPerServer,
            Proxy = opts.Proxy
        });
        Initialize(_environment, client, opts);
    }
    
    /// <summary>
    /// Disposes the underlying HttpClient instance.
    /// </summary>
    public void Dispose()
    {
        try { _httpClient.Dispose(); }catch { /* ignored */}
    }

    /// <summary>
    /// Sends an asynchronous HTTP request to the PayPal API.
    /// Automatically adds an Authorization header if not already present.
    /// Retries exactly once on 401 Unauthorized by refreshing the access token.
    /// </summary>
    /// <param name="request">The HTTP request to send.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation, containing the HTTP response.</returns>
    public async Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default)
    {
        if (!request.Headers.ContainsKey("Authorization"))
        {
            await EnsureAccessTokenAsync(cancellationToken);
            if (!string.IsNullOrEmpty(_accessToken?.Token))
                request.Headers["Authorization"] = $"Bearer {_accessToken.Token}";
        }

        byte[]? contentBuffer = null;
        if (request.Content != null)
            contentBuffer = await request.Content.ReadAsByteArrayAsync(cancellationToken);

        HttpResponseMessage response = null!;
        bool retriedOnAuth = false;
        // Add +1 because if the MaxRetries is 1 then only the base operation will run, and it won't retry.
        for (int i = 0; i < _options.MaxRetries + 1; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (contentBuffer != null && i > 0)
            {
                var newContent = new ByteArrayContent(contentBuffer);
                if (request.Content != null)
                    foreach (var header in request.Content.Headers)
                        newContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
                request.Content = newContent;
            }
                
            try
            {
                response = await _httpClient.SendAsync(request.ToHttpRequestMessage(), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (HttpRequestException) when (i + 1 < _options.MaxRetries)
            {
                await Task.Delay(_options.RetryDelay, cancellationToken);
                continue;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized && !retriedOnAuth)
            {
                response.Dispose();
                retriedOnAuth = true;
                await EnsureAccessTokenAsync(cancellationToken, forceRefresh: true);
                if (!string.IsNullOrEmpty(_accessToken?.Token))
                    request.Headers["Authorization"] = $"Bearer {_accessToken.Token}";
                continue;
            }

            if (((response.StatusCode == HttpStatusCode.TooManyRequests && _options.RetryOnRateLimit) || (int)response.StatusCode >= 500)
                && i + 1 < _options.MaxRetries)
            {
                response.Dispose();
                await Task.Delay(_options.RetryDelay, cancellationToken);
                continue;
            }
            break;
        }
        return response;
    }

    /// <summary>
    /// Ensures a valid (non-expired) access token is available.
    /// Uses a semaphore to prevent concurrent token-fetch calls.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <param name="forceRefresh">When <c>true</c>, always fetches a new token even if the cached one is still valid.</param>
    private async Task EnsureAccessTokenAsync(CancellationToken cancellationToken, bool forceRefresh = false)
    {
        if (!forceRefresh && _accessToken != null && !_accessToken.IsExpired())
            return;

        await _semaphore.WaitAsync(cancellationToken);
        try
        {
            if (forceRefresh || _accessToken == null || _accessToken.IsExpired())
                _accessToken = await FetchAccessTokenAsync(cancellationToken);
        }
        finally
        {
            _semaphore.Release();
        }
    }

    /// <summary>
    /// Fetches a new access token from the PayPal API.
    /// Handles both access token and refresh token responses.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing the fetched access token.</returns>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the access token retrieval fails. The message includes the HTTP status and response body
    /// when the server returns a non-success status code.
    /// </exception>
    private async Task<AccessToken> FetchAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        var tokenRequest = new AccessTokenRequestBody(_environment, _refreshToken);
        using var response = await _httpClient.SendAsync(tokenRequest.ToHttpRequestMessage(), cancellationToken);
        var json = await response.Content.ReadAsStringAsync(cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException(
                $"Failed to retrieve access token. HTTP {(int)response.StatusCode}: {response.ReasonPhrase}. Response body: {json}");
        }

        var accessToken = JsonSerializer.Deserialize(json, PayPalSDKJsonContext.Default.AccessToken);
        if (accessToken != null)
            return accessToken;

        var refreshToken = JsonSerializer.Deserialize(json, PayPalSDKJsonContext.Default.RefreshToken);
        if (refreshToken != null)
            return refreshToken.ToAccessToken();

        throw new InvalidOperationException("Failed to deserialize access token response. Response body: " + json);
    }
}