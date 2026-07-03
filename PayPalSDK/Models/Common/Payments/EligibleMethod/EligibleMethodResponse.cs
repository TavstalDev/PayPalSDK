using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents the response containing eligible payment methods and associated payment tokens for a customer.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleMethodResponse
{
    /// <summary>
    /// Gets or sets the eligible payment methods available for the customer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("eligible_methods")]
    public EligibleMethods? EligibleMethods { get; set; }
    
    /// <summary>
    /// Gets or sets a collection of payment tokens that can be used for future transactions.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payment_tokens")]
    public List<EligiblePaymentToken>? PaymentTokens { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}