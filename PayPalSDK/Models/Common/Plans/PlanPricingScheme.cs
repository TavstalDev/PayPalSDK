using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the pricing scheme for a subscription plan.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PlanPricingScheme
{
    /// <summary>
    /// Gets or sets the sequence number of the billing cycle associated with the pricing scheme.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("billing_cycle_sequence")]
    [Required]
    public int? BillingCycleSequence { get; set; }

    /// <summary>
    /// Gets or sets the pricing scheme details for the subscription plan.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("pricing_scheme")]
    public PlanPricingSchemeData? PricingScheme { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}