using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

[DataContract]
public class IncorrectTransactionAmount
{
    [JsonPropertyName("correct_transaction_amount")]
    public Money? CorrectTransactionAmount { get; set; }
    
    [JsonPropertyName("corrent_transaction_asset")]
    public Asset? CorrentTransactionAsset { get; set; }
    
    [JsonPropertyName("correct_transaction_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CorrectTransactionTime { get; set; }
    
    public DateTime? CorrectTransactionTimeAsDateTime => DateTimeHelper.FromISO8601(CorrectTransactionTime);
}