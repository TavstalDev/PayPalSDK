using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to retrieve authorized payment details from PayPal.
/// </summary>
public class PaymentGetAuthorizedDetailsRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentGetAuthorizedDetailsRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">
    /// The unique identifier for the authorization whose details are to be retrieved.
    /// </param>
    public PaymentGetAuthorizedDetailsRequest(string authorizationId)
        :
        base(HttpMethod.Get, $"/v2/payments/authorizations/{authorizationId}", typeof(AuthorizedPaymentBody))
    {
        // No additional initialization required
    }
}