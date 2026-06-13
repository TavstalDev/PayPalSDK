using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to refund a captured payment.
/// </summary>
public class PaymentRefundRequest : HttpRequestBase<RefundPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentRefundRequest"/> class.
    /// </summary>
    /// <param name="captureId">The unique identifier of the captured payment to be refunded.</param>
    /// <param name="body">The body of the payment refund request containing refund details.</param>
    public PaymentRefundRequest(string captureId, PaymentRefundRequestBody body)
        :
        base(HttpMethod.Get, $"/v2/payments/captures/{captureId}/refund")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.PaymentRefundRequestBody);
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentRefundRequest"/> for method chaining.</returns>
    public PaymentRefundRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}