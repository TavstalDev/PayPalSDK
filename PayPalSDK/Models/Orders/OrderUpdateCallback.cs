using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents an HTTP request to trigger or send an order update callback to the PayPal API.
/// </summary>
public class OrderUpdateCallback : HttpRequestBase<OrderBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderUpdateCallback"/> class.
    /// </summary>
    /// <param name="requestBody">The <see cref="OrderUpdateCallbackRequestBody"/> containing the callback details and order update information to send to PayPal.</param>
    public OrderUpdateCallback(OrderUpdateCallbackRequestBody requestBody) 
        : base(HttpMethod.Post, "/v2/checkout/orders/order-update-callback")
    {
        Content = JsonContent.Create(requestBody, PayPalSDKJsonContext.Default.OrderUpdateCallbackRequestBody);
    }

    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="OrderUpdateCallback"/> for method chaining.</returns>
    public OrderUpdateCallback PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}