using System.Net;
using System.Net.Http.Headers;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http.Clients;
using Tavstal.PayPalSDK.Models.Auth;
using Tavstal.PayPalSDK.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents a PayPal HTTP client for sending requests to the PayPal API.
/// </summary>
public sealed class PayPalHttpClient : IPayPalHttpClient, IDisposable
{
    private readonly HttpClient _httpClient;
    private AccessToken? _accessToken;
    private readonly string? _refreshToken;
    private readonly EnvironmentBase _environment;
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private readonly PayPalClientOptions _options;
    
    /// <summary>
    /// Provides operations for retrieving and converting currency exchange rates.
    /// </summary>
    public CurrencyExchangeClient CurrencyExchange { get; }

    /// <summary>
    /// Provides operations for managing and responding to customer disputes.
    /// </summary>
    public DisputesClient Disputes { get; }

    /// <summary>
    /// Provides operations for creating, sending, and managing invoices.
    /// </summary>
    public InvoicesClient Invoices { get; }

    /// <summary>
    /// Provides operations for creating, capturing, authorizing, and retrieving orders.
    /// </summary>
    public OrdersClient Orders { get; }

    /// <summary>
    /// Provides operations for creating and managing vaulted payment method tokens.
    /// </summary>
    public PaymentMethodTokensClient PaymentMethodTokens { get; }

    /// <summary>
    /// Provides operations for working with payment resources, such as captures, authorizations, and refunds.
    /// </summary>
    public PaymentResourcesClient PaymentResources { get; }

    /// <summary>
    /// Provides operations for creating and managing direct payment transactions.
    /// </summary>
    public PaymentsClient Payments { get; }

    /// <summary>
    /// Provides operations for managing product catalog entries.
    /// </summary>
    public ProductCatalogClient ProductCatalog { get; }

    /// <summary>
    /// Provides operations for creating and managing subscription plans and agreements.
    /// </summary>
    public SubscriptionsClient Subscriptions { get; }

    /// <summary>
    /// Provides operations for creating and updating shipment tracking information.
    /// </summary>
    public TrackingClient Tracking { get; }

    /// <summary>
    /// Provides operations for querying historical transaction activity.
    /// </summary>
    public TransactionSearchClient TransactionSearch { get; }

    /// <summary>
    /// Provides operations for managing webhooks and event subscriptions.
    /// </summary>
    public WebhooksClient Webhooks { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PayPalHttpClient"/> class with the specified environment and optional client options.
    /// </summary>
    /// <param name="environment">The environment configuration.</param>
    /// <param name="options">Optional client options for configuration.</param>
    public PayPalHttpClient(EnvironmentBase environment, PayPalClientOptions? options = null)
    {
        _options = options ?? new PayPalClientOptions();
        _environment = environment;
        _refreshToken = _options.RefreshToken;
        _httpClient = new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = _options.EnableCompression ? DecompressionMethods.GZip | DecompressionMethods.Deflate : DecompressionMethods.None,
            MaxConnectionsPerServer = _options.MaxConnectionsPerServer,
            Proxy = _options.Proxy
        });
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
    /// Disposes the underlying HttpClient instance.
    /// </summary>
    public void Dispose()
    {
        _httpClient.Dispose();
    }

    /// <summary>
    /// Sends an asynchronous HTTP request to the PayPal API.
    /// Automatically adds an Authorization header if not already present.
    /// </summary>
    /// <param name="request">The HTTP request to send.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation, containing the HTTP response.</returns>
    public async Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default)
    {
        // Adds the Authorization header if missing, fetching a new access token if necessary.
        if (!request.Headers.Contains("Authorization"))
        {
            if (_accessToken == null || _accessToken.IsExpired())
            {
                try 
                {
                    await _semaphore.WaitAsync(cancellationToken);
                    if (_accessToken == null || _accessToken.IsExpired()) // Check again
                        _accessToken = await FetchAccessTokenAsync(cancellationToken);
                }
                finally
                {
                    _semaphore.Release();
                }
            }
            if (!string.IsNullOrEmpty(_accessToken.Token))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken.Token);
        }

        byte[]? contentBuffer = null;
        if (request.Content != null)
            contentBuffer = await request.Content.ReadAsByteArrayAsync(cancellationToken);

        HttpResponseMessage response = null!; // Initialize response to avoid compiler warning
        for (int i = 0; i < _options.MaxRetries + 1; i++) // Add +1 because if the MaxRetries is 1 then only the base operation will run, and it won't retry.
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
                response = await _httpClient.SendAsync(request, cancellationToken);
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
    /// Fetches a new access token from the PayPal API.
    /// Handles both access token and refresh token responses.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing the fetched access token.</returns>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <exception cref="InvalidOperationException">Thrown if the access token retrieval fails.</exception>
    private async Task<AccessToken> FetchAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            // Creates a request to obtain an access token.
            var tokenRequest = new AccessTokenRequestBody(_environment, _refreshToken);
            using var response = await _httpClient.SendAsync(tokenRequest, cancellationToken);
            response.EnsureSuccessStatusCode();

            // Deserializes the response into an access token or refresh token.
            var json = await response.Content.ReadAsStringAsync(cancellationToken);
            var accessToken = JsonSerializer.Deserialize(json, PayPalSDKJsonContext.Default.AccessToken);
            if (accessToken == null)
            {
                var refreshToken =
                    JsonSerializer.Deserialize(json, PayPalSDKJsonContext.Default.RefreshToken);
                if (refreshToken != null)
                    return refreshToken.ToAccessToken();

                throw new InvalidOperationException("Failed to deserialize access token response.");
            }

            return accessToken;
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Failed to retrieve access token", ex);
        }
    }
}