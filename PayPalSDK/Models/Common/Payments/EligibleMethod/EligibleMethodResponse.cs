using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents the response containing eligible payment methods and associated payment tokens for a customer.
/// </summary>
public class EligibleMethodResponse
{
    /// <summary>
    /// Gets or sets the eligible payment methods available for the customer.
    /// </summary>
    [JsonPropertyName("eligible_methods")]
    public EligibleMethods? EligibleMethods { get; set; }
    
    /// <summary>
    /// Gets or sets a collection of payment tokens that can be used for future transactions.
    /// </summary>
    [JsonPropertyName("payment_tokens")]
    public List<EligiblePaymentToken>? PaymentTokens { get; set; }
}