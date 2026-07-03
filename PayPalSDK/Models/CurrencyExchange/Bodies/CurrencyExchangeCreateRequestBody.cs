using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents the request body used to create one or more currency exchange quotes.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CurrencyExchangeCreateRequestBody
{
    /// <summary>
    /// Gets or sets the organization identifier or name associated with the quote request.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("organization")]
    [StringLength(maximumLength: 100, MinimumLength = 2)]
    public string? Organization { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of quote items to be processed for currency exchange.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("quote_items")]
    public List<CurrencyExchangeQuoteItem>?  QuoteItems { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}