using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Transactions;

namespace Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

[DataContract]
public class TransactionListBalanceResponseBody
{
    [JsonPropertyName("balances")]
    public List<Balance>? Balances { get; set; }
    
    [JsonPropertyName("account_id")]
    [StringLength(13)]
    [RegularExpression("^[2-9A-HJ-NP-Z]{13}$")]
    public string? AccountId { get; set; }
    
    [JsonPropertyName("as_of_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? AsOfTime { get; set; }
    
    [JsonPropertyName("last_refresh_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? LastRefreshTime { get; set; }
}