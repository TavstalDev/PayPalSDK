using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents auction-related details associated with a transaction,
/// including auction source metadata, buyer identifier, and closing time.
/// </summary>
public class TransactionAuctionInfo
{
    /// <summary>
    /// Gets or sets the name of the auction platform or site.
    /// </summary>
    [JsonPropertyName("auction_site")]
    [StringLength(200)]
    public string? AuctionSite { get; set; }
    
    /// <summary>
    /// Gets or sets an auction item reference, such as the listing URL
    /// or site-specific item location/identifier.
    /// </summary>
    [JsonPropertyName("auction_item_site")]
    [StringLength(4000)]
    public string? AuctionItemSite { get; set; }
    
    /// <summary>
    /// Gets or sets the buyer identifier used by the auction platform.
    /// </summary>
    [JsonPropertyName("auction_buyer_id")]
    [StringLength(500)]
    public string? AuctionBuyerId { get; set; }
    
    /// <summary>
    /// Gets or sets the auction closing date-time in ISO 8601 string format.
    /// </summary>
    [JsonPropertyName("auction_closing_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? AuctionClosingDate { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="AuctionClosingDate"/>,
    /// or <see langword="null"/> when the source value is missing or cannot be parsed.
    /// </summary>
    public DateTime? AuctionClosingDateAsDateTime => DateTimeHelper.FromISO8601(AuctionClosingDate);
}