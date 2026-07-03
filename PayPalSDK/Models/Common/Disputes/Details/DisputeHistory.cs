using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a historical event in the lifecycle of a dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeHistory
{
    /// <summary>
    /// Gets or sets the actor that triggered the history event.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("actor")]
    [StringLength(255)]
    public string? Actor { get; set; }
    
    /// <summary>
    /// Gets or sets the event type describing the history entry.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("event_type")]
    [StringLength(255)]
    public string? EventType { get; set; }
    
    /// <summary>
    /// Gets or sets optional notes associated with the event.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Gets or sets the time the offer-related event occurred, in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("offer_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? OfferTime { get; set; }
    
    /// <summary>
    /// Gets or sets the offer type associated with this history event.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("offer_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? OfferType { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary offer amount associated with the event.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("offer_amount")]
    public Money? OfferAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute lifecycle stage at the time of the event.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("dispute_life_cycle_stage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? DisputeLifeCycleStage { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}