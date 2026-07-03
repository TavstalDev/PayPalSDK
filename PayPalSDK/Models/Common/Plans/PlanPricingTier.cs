using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents a pricing tier for a subscription plan with quantity-based pricing.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PlanPricingTier
{
    /// <summary>
    /// Gets or sets the starting quantity for this pricing tier.
    /// </summary>
    /// <remarks>
    /// This value represents the minimum quantity (inclusive) at which this tier's pricing becomes applicable.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("starting_quantity")]
    public string? StartingQuantity { get; set; }
    
    /// <summary>
    /// Gets or sets the ending quantity for this pricing tier.
    /// </summary>
    /// <remarks>
    /// This value represents the maximum quantity (inclusive) for which this tier's pricing applies.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("ending_quantity")]
    public string? EndingQuantity { get; set; }
    
    /// <summary>
    /// Gets or sets the price amount for this pricing tier.
    /// </summary>
    /// <remarks>
    /// This <see cref="Money"/> object contains the currency and value applicable to quantities
    /// within the starting and ending quantity range defined for this tier.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}