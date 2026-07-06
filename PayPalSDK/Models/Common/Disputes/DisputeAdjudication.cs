using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents an adjudication event recorded during a dispute lifecycle.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAdjudication
{
    /// <summary>
    /// Gets or sets the adjudication type code.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("type")]
    [Required]
    public EAdjudicationType Type { get; set; }
    
    /// <summary>
    /// Gets or sets the adjudication timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("adjudication_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? AdjudicationTime { get; set; }
    
    /// <summary>
    /// Gets or sets the reason code associated with this adjudication.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    public EAdjudicationReason? Reason { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute lifecycle stage at the time of adjudication.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("dispute_life_cycle_stage")]
    public EDisputeLifeCycleStage? DisputeLifeCycleStage { get; set; }
    
    /// <summary>
    /// Gets the <see cref="AdjudicationTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? AdjucationTimeAsDateTime => DateTimeHelper.FromISO8601(AdjudicationTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}