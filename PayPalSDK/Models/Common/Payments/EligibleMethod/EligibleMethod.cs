using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a payment method eligible for use in a given context.
/// </summary>
public class EligibleMethod
{
    /// <summary>
    /// Gets or sets a value indicating whether this payment method can be vaulted.
    /// </summary>
    [JsonPropertyName("can_be_vaulted")]
    public bool CanBeVaulted { get; set; }
    
    /// <summary>
    /// Gets or sets the ISO country code associated with this eligible method.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the product code for this payment method.
    /// </summary>
    [JsonPropertyName("product_code")]
    public string? ProductCode { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this method is eligible in the PayPal network.
    /// </summary>
    [JsonPropertyName("eligible_in_paypal_network")]
    public bool EligibleInPayPalNetwork { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this method is recommended.
    /// </summary>
    [JsonPropertyName("recommended")]
    public bool Recommended { get; set; }
    
    /// <summary>
    /// Gets or sets the recommendation priority, where lower values typically indicate higher priority.
    /// </summary>
    [JsonPropertyName("recommended_priority")]
    public int RecommendedPriority { get; set; }
}