using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

public class DisputeSupportingInfo
{
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    [JsonPropertyName("source")]
    [StringLength(255)]
    public string? Source { get; set; }
    
    [JsonPropertyName("provided_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ProvidedTime { get; set; }
    
    [JsonPropertyName("dispute_life_cycle_stage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? DisputeLifeCycleStage { get; set; }
    
    public DateTime? ProvidedTimeDateTime => DateTimeHelper.FromISO8601(ProvidedTime);
}