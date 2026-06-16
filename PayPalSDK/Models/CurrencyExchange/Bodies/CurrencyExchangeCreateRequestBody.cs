using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents the request body used to create one or more currency exchange quotes.
/// </summary>
[DataContract]
public class CurrencyExchangeCreateRequestBody
{
    /// <summary>
    /// Gets or sets the organization identifier or name associated with the quote request.
    /// </summary>
    [JsonPropertyName("organization")]
    [StringLength(maximumLength: 100, MinimumLength = 2)]
    public string? Organization { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of quote items to be processed for currency exchange.
    /// </summary>
    [JsonPropertyName("quote_items")]
    public required List<CurrencyExchangeQuoteItem>  QuoteItems { get; set; }
}