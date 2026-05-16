using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to retrieve authorized payment details from PayPal.
/// </summary>
public class PaymentGetAuthorizedDetailsRequest : HttpRequestBase<AuthorizedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentGetAuthorizedDetailsRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">
    /// The unique identifier for the authorization whose details are to be retrieved.
    /// </param>
    public PaymentGetAuthorizedDetailsRequest(string authorizationId)
        :
        base(HttpMethod.Get, $"/v2/payments/authorizations/{authorizationId}")
    {
        // No additional initialization required
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentGetAuthorizedDetailsRequest"/> for method chaining.</returns>
    public PaymentGetAuthorizedDetailsRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}