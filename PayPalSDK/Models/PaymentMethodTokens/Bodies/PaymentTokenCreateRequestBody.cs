using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

/// <summary>
/// Represents the request payload used to create a payment token.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentTokenCreateRequestBody
{
    /// <summary>
    /// Gets or sets the payment source details that will be tokenized.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("payment_source")]
    [Required]
    public PaymentSource? PaymentSource { get; set; }
    
    /// <summary>
    /// Gets or sets optional customer information associated with the payment token.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}