using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeHistory
{
    [JsonPropertyName("actor")]
    [StringLength(255)]
    public string? Actor { get; set; }
    
    [JsonPropertyName("event_type")]
    [StringLength(255)]
    public string? EventType { get; set; }
    
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    [JsonPropertyName("offer_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? OfferTime { get; set; }
    
    [JsonPropertyName("offer_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? OfferType { get; set; }
    
    [JsonPropertyName("offer_amount")]
    public Money? OfferAmount { get; set; }
    
    [JsonPropertyName("dispute_life_cycle_stage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? DisputeLifeCycleStage { get; set; }
}