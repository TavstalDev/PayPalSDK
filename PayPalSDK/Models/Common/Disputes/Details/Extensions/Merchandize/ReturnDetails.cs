using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

[DataContract]
public class ReturnDetails
{
    [JsonPropertyName("mode")]
    [StringLength(255)]
    public string?  Mode { get; set; }
    
    [JsonPropertyName("receipt")]
    public bool Receipt { get; set; }
    
    [JsonPropertyName("return_confirmation_number")]
    [StringLength(255)]
    public string?  ReturnConfirmationNumber { get; set; }
    
    [JsonPropertyName("returned")]
    public bool Returned { get; set; }
    
    [JsonPropertyName("return_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string?  ReturnTime { get; set; }
    
    public DateTime? ReturnTimeAsDateTime => DateTimeHelper.FromISO8601(ReturnTime);
}