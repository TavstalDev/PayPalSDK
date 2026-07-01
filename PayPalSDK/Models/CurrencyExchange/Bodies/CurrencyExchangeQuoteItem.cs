using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents a single currency exchange quote item, including base amount,
/// source/target currencies, optional FX identifier, and optional markup percentage.
/// </summary>
public class CurrencyExchangeQuoteItem
{
    /// <summary>
    /// Gets or sets the base amount used to request or calculate the currency exchange quote.
    /// </summary>
    [JsonPropertyName("base_amount")]
    [StringLength(32)]
    public string? BaseAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the foreign exchange identifier associated with this quote item.
    /// </summary>
    [JsonPropertyName("fx_id")]
    [StringLength(4000)]
    public string? FxId { get; set; }
    
    /// <summary>
    /// Gets or sets the 3-letter ISO currency code for the base currency.
    /// </summary>
    [JsonPropertyName("base_currency")]
    [StringLength(3)]
    public string? BaseCurrency { get; set; }
    
    /// <summary>
    /// Gets or sets the 3-letter ISO currency code for the quote currency.
    /// </summary>
    [JsonPropertyName("quote_currency")]
    [StringLength(3)]
    public string? QuoteCurrency { get; set; }
    
    /// <summary>
    /// Gets or sets the markup percentage applied to the exchange rate.
    /// </summary>
    [JsonPropertyName("markup_percent")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? MarkupPercent { get; set; }
}