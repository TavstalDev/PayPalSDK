using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to reauthorize a payment authorization.
/// </summary>
public class PaymentReauthorizeRequest : HttpRequestBase<AuthorizedPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentReauthorizeRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">The unique identifier of the payment authorization to be reauthorized.</param>
    /// <param name="body">The body of the payment reauthorization request containing reauthorization details. Optional.</param>
    public PaymentReauthorizeRequest(string authorizationId, PaymentReauthorizeRequestBody? body = null)
        :
        base(HttpMethod.Post, $"/v2/payments/authorizations/{authorizationId}/reauthorize")
    {
        if (body == null)
            return;

        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.PaymentReauthorizeRequestBody);
    }
    
    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentReauthorizeRequest"/> for method chaining.</returns>
    public PaymentReauthorizeRequest PaypalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
}