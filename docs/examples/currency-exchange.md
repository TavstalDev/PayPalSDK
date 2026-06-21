# Currency Exchange API Examples

The Currency Exchange API allows you to get currency exchange rates and convert amounts between currencies.

## Get Currency Exchange Rate

Get the exchange rate between two currencies.

```csharp
using Tavstal.PayPalSDK.Models.CurrencyExchange;
using Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

// Create request for currency exchange
var body = new CurrencyExchangeCreateRequestBody
{
    QuoteItems = [
       new CurrencyExchangeQuoteItem
       {
           BaseCurrency = "USD",
           BaseAmount = "10.00",
           QuoteCurrency = "EUR",
           MarkupPercent = "1"
       }
    ]
};

// Get exchange rate
var request = new CurrencyExchangeCreateRequest(body);
var response = await client.SendAsync(request);

// Parse the response
var exchangeRate = await request.GetResponseBodyAsync(response);

foreach (var result in exchangeRate!.ExchangeQuoteRates)
{
    Console.WriteLine($"Base: {result.BaseAmount.Value} {result.BaseAmount.CurrencyCode}");
    Console.WriteLine($"Quote: {result.QuoteAmount.Value} {result.QuoteAmount.CurrencyCode}");
}
```

