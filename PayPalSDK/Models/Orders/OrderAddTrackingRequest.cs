using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents an HTTP request to add or update shipment tracking information for a PayPal order.
/// </summary>
public class OrderAddTrackingRequest : HttpRequestBase<OrderBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderAddTrackingRequest"/> class.
    /// </summary>
    /// <param name="orderId">The unique identifier of the PayPal order to which tracking information will be added.</param>
    /// <param name="requestBody">The <see cref="OrderTrackingRequestBody"/> containing the tracking details such as carrier, tracking number, and items.</param>
    public OrderAddTrackingRequest(string orderId, OrderTrackingRequestBody requestBody) 
        : base(HttpMethod.Post, $"/v2/checkout/orders/{orderId}/track")
    {
        Content = JsonContent.Create(requestBody, PayPalSDKJsonContext.Default.OrderTrackingRequestBody);
    }

    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="OrderAddTrackingRequest"/> for method chaining.</returns>
    public OrderAddTrackingRequest PayPalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}