using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents the payment sources available to a customer, including PayPal and Venmo.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligiblePaymentSource
{
    /// <summary>
    /// Gets or sets the PayPal payment source eligibility information.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("paypal")]
    public EligiblePayPalSource? PayPal { get; set; }
    
    /// <summary>
    /// Gets or sets the Venmo payment source eligibility information.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("venmo")]
    public EligibleVenmoSource? Venmo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}