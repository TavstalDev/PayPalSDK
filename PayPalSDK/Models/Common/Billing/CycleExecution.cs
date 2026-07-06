using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents the execution details of a billing cycle.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CycleExecution
{
    /// <summary>
    /// Gets or sets the type of tenure for the billing cycle.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("tenure_type")]
    [Required]
    public ETenureType TenureType { get; set; }

    /// <summary>
    /// Gets or sets the sequence number of the billing cycle.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("sequence")]
    public int? Sequence { get; set; }

    /// <summary>
    /// Gets or sets the number of cycles that have been completed.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("cycles_completed")]
    public int? CyclesCompleted { get; set; }

    /// <summary>
    /// Gets or sets the number of cycles remaining in the billing cycle.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("cycles_remaining")]
    public int CyclesRemaining { get; set; }

    /// <summary>
    /// Gets or sets the version of the current pricing scheme applied to the billing cycle.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("current_pricing_scheme_version")]
    public int CurrentPricingSchemeVersion { get; set; }

    /// <summary>
    /// Gets or sets the total number of cycles in the billing cycle.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("total_cycles")]
    public int TotalCycles { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}