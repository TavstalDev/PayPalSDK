using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents a PayPal currency exchange quote rate, including source/target amounts,
/// identifiers, and timestamp metadata returned by the API.
/// </summary>
public class CurrencyExchangeQuoteRate
{
    /// <summary>
    /// Gets or sets the exchange rate value used for the quote.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    [StringLength(32)]
    public required string ExchangeRate { get; set; }
    
    /// <summary>
    /// Gets or sets the foreign exchange identifier associated with this quote.
    /// </summary>
    [JsonPropertyName("fx_id")]
    [StringLength(4000)]
    public string? FxId { get; set; }
    
    /// <summary>
    /// Gets or sets the base amount (source currency amount) used to calculate the quote.
    /// </summary>
    [JsonPropertyName("base_amount")]
    public required Money BaseAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the quoted amount (target currency amount) returned for the exchange.
    /// </summary>
    [JsonPropertyName("quote_amount")]
    public required Money QuoteAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the ISO-8601 timestamp string indicating when the quote expires.
    /// </summary>
    [JsonPropertyName("expiry_time")]
    [StringLength(maximumLength:64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ExpiryTime { get; set; }
    
    /// <summary>
    /// Gets or sets the ISO-8601 timestamp string indicating when the exchange rate should be refreshed.
    /// </summary>
    [JsonPropertyName("rate_refresh_time")]
    [StringLength(maximumLength:64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? RateRefreshTime { get; set; }
    
    /// <summary>
    /// Gets or sets the ISO-8601 timestamp string indicating when this quote was last updated.
    /// </summary>
    [JsonPropertyName("update_time")]
    [StringLength(maximumLength:64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="ExpiryTime"/>, if valid.
    /// </summary>
    public DateTime? ExpiryTimeAsDateTime => DateTimeHelper.FromISO8601(ExpiryTime);
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="RateRefreshTime"/>, if valid.
    /// </summary>
    public DateTime? RateRefreshTimeAsDateTime => DateTimeHelper.FromISO8601(RateRefreshTime);
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="UpdateTime"/>, if valid.
    /// </summary>
    public DateTime? UpdateTimeAsDateTime => DateTimeHelper.FromISO8601(UpdateTime);
}