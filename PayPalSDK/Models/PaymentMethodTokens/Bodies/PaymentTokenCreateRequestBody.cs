using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

/// <summary>
/// Represents the request payload used to create a payment token.
/// </summary>
[DataContract]
public class PaymentTokenCreateRequestBody
{
    /// <summary>
    /// Gets or sets the payment source details that will be tokenized.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public required PaymentSource PaymentSource { get; set; }
    
    /// <summary>
    /// Gets or sets optional customer information associated with the payment token.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }
}