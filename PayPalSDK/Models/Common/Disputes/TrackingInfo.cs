using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class TrackingInfo
{
    [JsonPropertyName("carrier_name")]
    [StringLength(255)]
    public required string CarrierName { get; set; }
    
    [JsonPropertyName("carrier_name_other")]
    [StringLength(2000)]
    public string? CarrierNameOther { get; set; }
    
    [JsonPropertyName("tracking_url")]
    public string? TrackingUrl { get; set; }
    
    [JsonPropertyName("tracking_number")]
    [StringLength(255)]
    public required string TrackingNumber { get; set; }
}