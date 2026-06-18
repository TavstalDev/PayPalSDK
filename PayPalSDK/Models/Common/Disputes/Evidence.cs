using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class Evidence
{
    [JsonPropertyName("evidence_type")]
    [StringLength(255)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? EvidenceType { get; set; }
    
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
    [JsonPropertyName("item_id")]
    [StringLength(255)]
    public string? ItemId { get; set; }
    
    [JsonPropertyName("evidence_info")]
    public List<EvidenceInfo>? EvidenceInfo { get; set; }
}