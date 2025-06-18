using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to retrieve the details of a refunded payment.
/// </summary>
public class PaymentGetRefundDetailsRequest : HttpRequestBase<RefundPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentGetRefundDetailsRequest"/> class.
    /// </summary>
    /// <param name="refundId">The unique identifier of the refunded payment.</param>
    public PaymentGetRefundDetailsRequest(string refundId)
        :
        base(HttpMethod.Get, $"/v2/payments/refunds/{refundId}")
    {
        // No additional content is needed for a GET request
    }
}