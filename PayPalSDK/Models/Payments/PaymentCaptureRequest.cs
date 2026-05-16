using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to capture a payment authorization.
/// </summary>
public class PaymentCaptureRequest : HttpRequestBase<CapturedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentCaptureRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">The unique identifier of the payment authorization to be captured.</param>
    /// <param name="body">The body of the payment capture request containing capture details.</param>
    public PaymentCaptureRequest(string authorizationId, PaymentCaptureRequestBody body)
        :
        base(HttpMethod.Post, $"/v2/payments/authorizations/{authorizationId}/capture")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentCaptureRequest"/> for method chaining.</returns>
    public PaymentCaptureRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}