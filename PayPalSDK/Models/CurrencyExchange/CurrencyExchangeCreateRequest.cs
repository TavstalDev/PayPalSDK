using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.CurrencyExchange;

/// <summary>
/// Represents an HTTP request that creates currency exchange rate quotes
/// via the PayPal pricing API.
/// </summary>
public class CurrencyExchangeCreateRequest : HttpRequestBase<CurrencyExchangeCreateResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyExchangeCreateRequest"/> class.
    /// </summary>
    /// <param name="body">
    /// The request payload containing organization details and quote items
    /// used to generate exchange rate quotes.
    /// </param>
    public CurrencyExchangeCreateRequest(CurrencyExchangeCreateRequestBody body)
        : base(HttpMethod.Post, "/v2/pricing/quote-exchange-rates")
    {
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.CurrencyExchangeCreateRequestBody);
    }
}