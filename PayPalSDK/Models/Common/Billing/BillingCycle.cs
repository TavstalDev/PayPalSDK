using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Plans;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents a billing cycle in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class BillingCycle
{
    /// <summary>
    /// Gets or sets the tenure type of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the type of tenure for the billing cycle.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("tenure_type")]
    [Required]
    public ETenureType TenureType { get; set; }

    /// <summary>
    /// Gets or sets the total number of cycles in the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and defaults to 1.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("total_cycles")]
    public int TotalCycles { get; set; } = 1;

    /// <summary>
    /// Gets or sets the sequence number of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and defaults to 1.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("sequence")]
    public int? Sequence { get; set; } = 1;

    /// <summary>
    /// Gets or sets the pricing scheme associated with the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the pricing details for the billing cycle.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("pricing_scheme")]
    public PlanPricingSchemeData? PricingScheme { get; set; }

    /// <summary>
    /// Gets or sets the start date of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the format YYYY-MM-DD.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("start_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? StartDate { get; set; }
    
    /// <summary>
    /// Gets or sets the frequency of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the frequency details for the billing cycle.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("frequency")]
    public BillingFrequency? Frequency { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}