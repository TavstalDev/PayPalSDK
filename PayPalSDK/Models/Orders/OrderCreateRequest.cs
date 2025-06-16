using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Orders;

/// <summary>
/// Represents a request to create an order within the PayPal SDK.
/// </summary>
public class OrderCreateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderCreateRequest"/> class.
    /// </summary>
    /// <param name="body">The request body containing the order creation details.</param>
    public OrderCreateRequest(OrderCreateRequestBody body)
        : base(HttpMethod.Post, "/v2/checkout/orders", typeof(OrderBody))
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="OrderCreateRequest"/> for method chaining.</returns>
    public OrderCreateRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}