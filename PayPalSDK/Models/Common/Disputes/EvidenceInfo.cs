using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents evidence information related to a PayPal dispute, including tracking information and refund IDs.
/// </summary>
public class EvidenceInfo
{
    /// <summary>
    /// Gets or sets the list of tracking information associated with the disputed item.
    /// </summary>
    [JsonPropertyName("tracking_info")]
    public List<TrackingInfo>? TrackingInfo { get; set; }
    
    /// <summary>
    /// Gets or sets the list of refund IDs associated with the disputed transaction.
    /// </summary>
    [JsonPropertyName("refund_ids")]
    public List<string>? RefundIds { get; set; }
}