using Tavstal.PayPalSDK.Http;

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
}