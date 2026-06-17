using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Transactions;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

[DataContract]
public class TransactionListResponseBody
{
    [JsonPropertyName("transaction_details")]
    public List<TransactionDetail>? TransactionDetails { get; set; }
    
    [JsonPropertyName("account_number")]
    [StringLength(255)]
    public string? AccountNumber { get; set; }
    
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    [JsonPropertyName("start_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? StartDate { get; set; }
    
    [JsonPropertyName("end_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? EndDate { get; set; }
    
    [JsonPropertyName("last_refreshed_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? LastRefreshedDate { get; set; }
    
    public DateTime? StartDateAsDateTime => DateTimeHelper.FromISO8601(StartDate);
    public DateTime? EndDateAsDateTime => DateTimeHelper.FromISO8601(EndDate);
    public DateTime? LastRefreshedDateAsDateTime => DateTimeHelper.FromISO8601(LastRefreshedDate);
}