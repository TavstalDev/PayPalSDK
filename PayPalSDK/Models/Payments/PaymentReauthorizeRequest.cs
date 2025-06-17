using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Payments;

/// <summary>
/// Represents a request to reauthorize a payment authorization.
/// </summary>
public class PaymentReauthorizeRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentReauthorizeRequest"/> class.
    /// </summary>
    /// <param name="authorizationId">The unique identifier of the payment authorization to be reauthorized.</param>
    /// <param name="body">The body of the payment reauthorization request containing reauthorization details. Optional.</param>
    public PaymentReauthorizeRequest(string authorizationId, PaymentReauthorizeRequest? body = null)
        :
        base(HttpMethod.Post, $"/v2/payments/authorizations/{authorizationId}/reauthorize", typeof(CapturedPaymentBody))
    {
        if (body == null)
            return;

        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}