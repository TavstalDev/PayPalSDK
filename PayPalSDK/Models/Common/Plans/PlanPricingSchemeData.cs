using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the pricing scheme configuration for a subscription plan.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PlanPricingSchemeData
{
    /// <summary>
    /// Gets or sets the pricing model type for this plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 24 characters.
    /// It specifies the pricing strategy, such as "FIXED", "TIERED", or other model identifiers.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("pricing_model")]
    [StringLength(24)]
    public string? PricingModel { get; set; }
    
    /// <summary>
    /// Gets or sets the fixed price for this plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and is typically used when the pricing model is fixed price.
    /// It contains the currency and amount for a single-tier or uniform pricing structure.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("fixed_price")]
    public Money? FixedPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the list of pricing tiers for this plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and is typically used when the pricing model is tiered or quantity-based.
    /// Each tier defines a quantity range and its associated price. This allows for volume-based or
    /// graduated pricing where the unit price changes based on the quantity purchased.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("tiers")]
    public List<PlanPricingTier>? Tiers { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}