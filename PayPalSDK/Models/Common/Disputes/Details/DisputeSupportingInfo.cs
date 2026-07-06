using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents additional supporting information submitted for a dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeSupportingInfo
{
    /// <summary>
    /// Gets or sets notes describing the supporting information.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Gets or sets supporting documents attached to this entry.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    /// <summary>
    /// Gets or sets the source that provided this supporting information.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("source")]
    public EDisputeSupportingSource? Source { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp when supporting information was provided, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("provided_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ProvidedTime { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute lifecycle stage associated with this supporting information.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("dispute_life_cycle_stage")]
    public EDisputeLifeCycleStage? DisputeLifeCycleStage { get; set; }
    
    /// <summary>
    /// Gets the <see cref="ProvidedTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? ProvidedTimeDateTime => DateTimeHelper.FromISO8601(ProvidedTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}