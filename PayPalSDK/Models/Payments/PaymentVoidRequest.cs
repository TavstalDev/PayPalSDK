using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to void a payment authorization.
/// </summary>
public class PaymentVoidRequest : HttpRequestBase<AuthorizedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentVoidRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">The unique identifier of the payment authorization to be voided.</param>
    public PaymentVoidRequest(string authorizationId)
        :
        base(HttpMethod.Post, $"/v2/payments/authorizations/{authorizationId}/void")
    {
        // No body is required for voiding an authorization, so no content is set.
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentVoidRequest"/> for method chaining.</returns>
    public PaymentVoidRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}