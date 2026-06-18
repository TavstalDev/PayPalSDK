using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class EvidenceInfo
{
    [JsonPropertyName("tracking_info")]
    public List<TrackingInfo>? TrackingInfo { get; set; }
    
    [JsonPropertyName("refund_ids")]
    public List<string>? RefundIds { get; set; }
}