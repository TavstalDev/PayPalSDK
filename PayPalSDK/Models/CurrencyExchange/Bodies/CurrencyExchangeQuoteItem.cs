using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents a single currency exchange quote item, including base amount,
/// source/target currencies, optional FX identifier, and optional markup percentage.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CurrencyExchangeQuoteItem
{
    /// <summary>
    /// Gets or sets the base amount used to request or calculate the currency exchange quote.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("base_amount")]
    [StringLength(32)]
    public string? BaseAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the foreign exchange identifier associated with this quote item.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("fx_id")]
    [StringLength(4000)]
    public string? FxId { get; set; }
    
    /// <summary>
    /// Gets or sets the 3-letter ISO currency code for the base currency.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("base_currency")]
    [StringLength(3)]
    public string? BaseCurrency { get; set; }
    
    /// <summary>
    /// Gets or sets the 3-letter ISO currency code for the quote currency.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("quote_currency")]
    [StringLength(3)]
    public string? QuoteCurrency { get; set; }
    
    /// <summary>
    /// Gets or sets the markup percentage applied to the exchange rate.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("markup_percent")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? MarkupPercent { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}