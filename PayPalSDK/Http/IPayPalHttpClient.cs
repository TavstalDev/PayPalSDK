using Tavstal.PayPalSDK.Http.Clients;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents a PayPal HTTP client capable of sending requests to the PayPal API.
/// </summary>
public interface IPayPalHttpClient
{
    /// <summary>
    /// Provides operations for retrieving and converting currency exchange rates.
    /// </summary>
    CurrencyExchangeClient CurrencyExchange { get; }

    /// <summary>
    /// Provides operations for managing and responding to customer disputes.
    /// </summary>
    DisputesClient Disputes { get; }

    /// <summary>
    /// Provides operations for creating, sending, and managing invoices.
    /// </summary>
    InvoicesClient Invoices { get; }

    /// <summary>
    /// Provides operations for creating, capturing, authorizing, and retrieving orders.
    /// </summary>
    OrdersClient Orders { get; }

    /// <summary>
    /// Provides operations for creating and managing vaulted payment method tokens.
    /// </summary>
    PaymentMethodTokensClient PaymentMethodTokens { get; }

    /// <summary>
    /// Provides operations for working with payment resources, such as captures, authorizations, and refunds.
    /// </summary>
    PaymentResourcesClient PaymentResources { get; }

    /// <summary>
    /// Provides operations for creating and managing direct payment transactions.
    /// </summary>
    PaymentsClient Payments { get; }

    /// <summary>
    /// Provides operations for managing product catalog entries.
    /// </summary>
    ProductCatalogClient ProductCatalog { get; }

    /// <summary>
    /// Provides operations for creating and managing subscription plans and agreements.
    /// </summary>
    SubscriptionsClient Subscriptions { get; }

    /// <summary>
    /// Provides operations for creating and updating shipment tracking information.
    /// </summary>
    TrackingClient Tracking { get; }

    /// <summary>
    /// Provides operations for querying historical transaction activity.
    /// </summary>
    TransactionSearchClient TransactionSearch { get; }

    /// <summary>
    /// Provides operations for managing webhooks and event subscriptions.
    /// </summary>
    WebhooksClient Webhooks { get; }
    
    /// <summary>
    /// Sends an HTTP request to the PayPal API.
    /// </summary>
    /// <param name="request">The HTTP request to send.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>A task representing the asynchronous operation, containing the HTTP response.</returns>
    Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default);
}