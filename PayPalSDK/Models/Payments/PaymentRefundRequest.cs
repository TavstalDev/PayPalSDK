using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to refund a captured payment.
/// </summary>
public class PaymentRefundRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentRefundRequest"/> class.
    /// </summary>
    /// <param name="captureId">The unique identifier of the captured payment to be refunded.</param>
    /// <param name="body">The body of the payment refund request containing refund details.</param>
    public PaymentRefundRequest(string captureId, PaymentRefundRequestBody body)
        :
        base(HttpMethod.Get, $"/v2/payments/captures/{captureId}/refund", typeof(RefundPaymentBody))
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}