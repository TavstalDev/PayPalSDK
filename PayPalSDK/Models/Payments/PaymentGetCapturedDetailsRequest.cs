using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to retrieve the details of a captured payment.
/// </summary>
public class PaymentGetCapturedDetailsRequest : HttpRequestBase<CapturedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentGetCapturedDetailsRequest"/> class.
    /// </summary>
    /// <param name="captureId">The unique identifier of the captured payment.</param>
    public PaymentGetCapturedDetailsRequest(string captureId)
        :
        base (HttpMethod.Get, $"/v2/payments/captures/{captureId}")
    {
        // No additional content is needed for a GET request
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentGetCapturedDetailsRequest"/> for method chaining.</returns>
    public PaymentGetCapturedDetailsRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}