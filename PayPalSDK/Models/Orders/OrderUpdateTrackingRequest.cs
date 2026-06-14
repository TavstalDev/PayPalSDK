using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents an HTTP PATCH request to update an existing shipment tracker for a PayPal order.
/// </summary>
public class OrderUpdateTrackingRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderUpdateTrackingRequest"/> class.
    /// </summary>
    /// <param name="orderId">The unique identifier of the PayPal order containing the tracker to be updated.</param>
    /// <param name="trackerId">The unique identifier of the specific tracker/shipment to be updated within the order.</param>
    /// <param name="operations">An array of <see cref="UpdateOperation"/> objects that define the changes to apply to the tracker using JSON Patch operations.</param>
    public OrderUpdateTrackingRequest(string orderId, string trackerId, List<UpdateOperation> operations) 
        : base(HttpMethod.Patch, $"/v2/checkout/orders/{orderId}/trackers/{trackerId}")
    {
        Content = JsonContent.Create(operations, PayPalSDKJsonContext.Default.ListUpdateOperation);
    }

    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="OrderUpdateTrackingRequest"/> for method chaining.</returns>
    public OrderUpdateTrackingRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}