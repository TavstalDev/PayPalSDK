using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a payment method eligible for use in a given context.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleMethod
{
    /// <summary>
    /// Gets or sets a value indicating whether this payment method can be vaulted.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("can_be_vaulted")]
    public bool CanBeVaulted { get; set; }
    
    /// <summary>
    /// Gets or sets the ISO country code associated with this eligible method.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the product code for this payment method.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("product_code")]
    public string? ProductCode { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this method is eligible in the PayPal network.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("eligible_in_paypal_network")]
    public bool EligibleInPayPalNetwork { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this method is recommended.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("recommended")]
    public bool Recommended { get; set; }
    
    /// <summary>
    /// Gets or sets the recommendation priority, where lower values typically indicate higher priority.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("recommended_priority")]
    public int RecommendedPriority { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}