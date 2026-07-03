using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a collection of eligible payment methods available for a customer.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleMethods
{
    /// <summary>
    /// Gets or sets the PayPal payment method eligibility information.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("paypal")]
    public EligibleMethod? PayPal { get; set; }
    
    /// <summary>
    /// Gets or sets the Venmo payment method eligibility information.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("venmo")]
    public EligibleMethod? Venmo { get; set; }
    
    /// <summary>
    /// Gets or sets the PayPal Credit payment method eligibility information.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("paypal_credit")]
    public EligibleMethod? PayPalCredit { get; set; }
    
    /// <summary>
    /// Gets or sets the PayPal Pay Later payment method eligibility information.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("paypal_pay_later")]
    public EligibleMethod? PayPalPayLater { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}