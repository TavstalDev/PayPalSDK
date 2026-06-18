using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeFundMovement
{
    [JsonPropertyName("party")]
    [StringLength(255)]
    public string? Party { get; set; }
    
    [JsonPropertyName("type")]
    [StringLength(255)]
    public string? Type { get; set; }
    
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
    
    [JsonPropertyName("asset")]
    public GrossAsset? Asset { get; set; }
    
    [JsonPropertyName("initiated_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? InitiatedTime { get; set; }
    
    [JsonPropertyName("reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Reason { get; set; }
    
    public DateTime? InitiatedTimeAsDateTime => DateTimeHelper.FromISO8601(InitiatedTime);
}