using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionAuctionInfo
{
    [JsonPropertyName("auction_site")]
    [StringLength(200)]
    public string? AuctionSite { get; set; }
    
    [JsonPropertyName("auction_item_site")]
    [StringLength(4000)]
    public string? AuctionItemSite { get; set; }
    
    [JsonPropertyName("auction_buyer_id")]
    [StringLength(500)]
    public string? AuctionBuyerId { get; set; }
    
    [JsonPropertyName("auction_closing_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? AuctionClosingDate { get; set; }
    
    public DateTime? AuctionClosingDateAsDateTime => DateTimeHelper.FromISO8601(AuctionClosingDate);
}