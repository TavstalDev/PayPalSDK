using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.PaymentMethodTokens;

/// <summary>
/// Represents an HTTP request to delete a specific payment token
/// from the PayPal Vault API.
/// </summary>
public class PaymentTokenDeleteRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentTokenDeleteRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique identifier of the payment token to delete.
    /// Must not exceed 36 characters.
    /// </param>
    public PaymentTokenDeleteRequest([StringLength(36)] string id) 
        : base(HttpMethod.Delete, $"/v3/vault/payment-tokens/{id}") { }

    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentTokenDeleteRequest"/> for method chaining.</returns>
    public PaymentTokenDeleteRequest PayPalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
    
}