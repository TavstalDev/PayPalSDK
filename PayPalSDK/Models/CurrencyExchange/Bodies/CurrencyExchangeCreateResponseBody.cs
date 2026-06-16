using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

/// <summary>
/// Represents the response body returned after creating currency exchange rate quotes.
/// </summary>
[DataContract]
public class CurrencyExchangeCreateResponseBody
{
    /// <summary>
    /// Gets or sets the collection of exchange rate quotes returned by the API.
    /// </summary>
    [JsonPropertyName("exchange_rate_quotes")]
    public required List<CurrencyExchangeQuoteRate> ExchangeQuoteRates { get; set; }
}