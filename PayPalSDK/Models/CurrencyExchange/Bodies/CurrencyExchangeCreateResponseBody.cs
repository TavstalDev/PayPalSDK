using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents the response body returned after creating currency exchange rate quotes.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CurrencyExchangeCreateResponseBody
{
    /// <summary>
    /// Gets or sets the collection of exchange rate quotes returned by the API.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("exchange_rate_quotes")]
    [Required]
    public List<CurrencyExchangeQuoteRate>? ExchangeQuoteRates { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}