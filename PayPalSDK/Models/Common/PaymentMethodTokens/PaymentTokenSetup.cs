using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.PaymentTokens;

namespace Tavstal.PayPalSDK.Models.Common.PaymentMethodTokens;

/// <summary>
/// Represents a payment token setup returned by the Payment Method Tokens API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentTokenSetup
{
    /// <summary>
    /// Gets or sets the unique identifier of the payment token.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(36)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the current lifecycle status of the payment token.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EPaymentTokenSetupStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the payment source details associated with this token.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payment_source")]
    public PaymentSource? PaymentSource { get; set; }
    
    /// <summary>
    /// Gets or sets HATEOAS links related to this payment token resource.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets customer information associated with this payment token.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}