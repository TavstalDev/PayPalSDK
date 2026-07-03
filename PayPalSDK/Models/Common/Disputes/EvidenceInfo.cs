using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents evidence information related to a PayPal dispute, including tracking information and refund IDs.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EvidenceInfo
{
    /// <summary>
    /// Gets or sets the list of tracking information associated with the disputed item.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("tracking_info")]
    public List<TrackingInfo>? TrackingInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the list of refund IDs associated with the disputed transaction.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("refund_ids")]
    public List<string>? RefundIds { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}