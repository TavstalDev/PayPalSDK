using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Http.Clients;

namespace Tavstal.PayPalSDK.Tests.Mocks;

public class FakePayPalHttpClient : IPayPalHttpClient
{
    private readonly Func<HttpRequestMessage, HttpResponseMessage> _responder;
    
    public FakePayPalHttpClient(Func<HttpRequestMessage, HttpResponseMessage> responder)
    {
        _responder = responder;
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
    /// Creates a new <see cref="FakePayPalHttpClient"/> with the specified responder function.
    /// </summary>
    /// <param name="responder">
    /// A function that takes an <see cref="HttpRequestMessage"/> and returns an <see cref="HttpResponseMessage"/>.
    /// </param>
    /// <returns>A new <see cref="FakePayPalHttpClient"/> instance.</returns>
    public static FakePayPalHttpClient CreateClient(Func<HttpRequestMessage, HttpResponseMessage> responder) =>
        new(responder);

    public CurrencyExchangeClient CurrencyExchange { get; }
    public DisputesClient Disputes { get; }
    public InvoicesClient Invoices { get; }
    public OrdersClient Orders { get; }
    public PaymentMethodTokensClient PaymentMethodTokens { get; }
    public PaymentResourcesClient PaymentResources { get; }
    public PaymentsClient Payments { get; }
    public ProductCatalogClient ProductCatalog { get; }
    public SubscriptionsClient Subscriptions { get; }
    public TrackingClient Tracking { get; }
    public TransactionSearchClient TransactionSearch { get; }
    public WebhooksClient Webhooks { get; }

    public Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_responder(request));
    }
}