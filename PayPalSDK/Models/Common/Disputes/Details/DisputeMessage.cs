using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeMessage
{
    [JsonPropertyName("posted_by")]
    [StringLength(255)]
    public string? PostedBy { get; set; }
    
    [JsonPropertyName("content")]
    [StringLength(255)]
    public string? Content { get; set; }
    
    [JsonPropertyName("documents")]
    public List<EvidenceDocument>? Documents { get; set; }
    
    [JsonPropertyName("time_posted")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TimePosted { get; set; }
    
    public DateTime? TimePostedDateTime => DateTimeHelper.FromISO8601(TimePosted);
}