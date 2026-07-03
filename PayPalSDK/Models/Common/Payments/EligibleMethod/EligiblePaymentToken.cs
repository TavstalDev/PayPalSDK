using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a payment token that identifies and contains details about a stored or eligible payment method.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligiblePaymentToken
{
    /// <summary>
    /// Gets or sets the unique identifier for this payment token.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the payment source details associated with this token.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payment_source")]
    public EligiblePaymentSource? PaymentSource { get; set; }
    
    /// <summary>
    /// Gets or sets a collection of HATEOAS links related to this payment token.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}