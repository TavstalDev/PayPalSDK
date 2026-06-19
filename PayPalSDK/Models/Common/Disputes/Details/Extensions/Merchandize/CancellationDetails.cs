using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

[DataContract]
public class CancellationDetails
{
    [JsonPropertyName("cancellation_number")]
    [StringLength(127)]
    public string? CancellationNumber { get; set; }
    
    [JsonPropertyName("cancelled")]
    public bool Cancelled { get; set; }
    
    [JsonPropertyName("cancellation_mode")]
    [StringLength(255)]
    public string? CancellationMode { get; set; }
    
    [JsonPropertyName("cancellation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CancellationDate { get; set; }
    
    public DateTime? CancellationDateAsDateTime => DateTimeHelper.FromISO8601(CancellationDate);
}