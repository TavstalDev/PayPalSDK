# Transaction Search API Examples

The Transaction Search API allows you to search for and list transactions and account balances.

## Search Transactions

Search for transactions with optional filters.

```csharp
using Tavstal.PayPalSDK.Models.TransactionSearch;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

// Search transactions
var request = new TransactionListRequest("2022-04-25T00:00:00-07:00", "2022-05-10T23:59:59:59-07:00", transactionId: "03A84379GE3808324",
    fields: "all");
var response = await client.SendAsync(request);

// Parse the response
var transactions = await request.GetResponseBodyAsync(response);

if (transactions?.TransactionDetails != null)
{
    foreach (var transaction in transactions.TransactionDetails)
    {
        Console.WriteLine($"Transaction ID: {transaction.TransactionInfo!.TransactionId}");
    }
}
```

> **High-level alternative:**
> ```csharp
> using Tavstal.PayPalSDK.Http.Clients;
> 
> var result = await client.TransactionSearch.ListAsync(
>     "2022-04-25T00:00:00-07:00", "2022-05-10T23:59:59:59-07:00",
>     transactionId: "03A84379GE3808324", fields: "all");
> if (result.IsSuccess && result.Value.TransactionDetails != null)
>     foreach (var transaction in result.Value.TransactionDetails)
>         Console.WriteLine($"Transaction ID: {transaction.TransactionInfo!.TransactionId}");
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```

## List Balances

Retrieve balance history.

```csharp
using Tavstal.PayPalSDK.Models.TransactionSearch;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

// Get balance history
var request = new TransactionListBalanceRequest("2021-02-22T00:00:00-07:00", "ALL");
var response = await client.SendAsync(request);

// Parse the response
var balances = await request.GetResponseBodyAsync(response);

if (balances?.Balances != null)
{
    foreach (var balance in balances.Balances)
    {
        Console.WriteLine($"Currency: {balance.TotalBalance!.CurrencyCode}");
        Console.WriteLine($"Amount: {balance.TotalBalance!.Value}");
    }
}
```

> **High-level alternative:**
> ```csharp
> var result = await client.TransactionSearch.ListBalancesAsync("2021-02-22T00:00:00-07:00", "ALL");
> if (result.IsSuccess && result.Value.Balances != null)
>     foreach (var balance in result.Value.Balances)
>     {
>         Console.WriteLine($"Currency: {balance.TotalBalance!.CurrencyCode}");
>         Console.WriteLine($"Amount: {balance.TotalBalance!.Value}");
>     }
> else
>     Console.WriteLine($"Error: {result.Error?.Message}");
> ```
