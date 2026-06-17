using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

namespace Tavstal.PayPalSDK.Models.TransactionSearch;

/// <summary>
/// Represents a request to retrieve a list of balances for transactions, with optional filtering by as-of time and currency code.
/// </summary>
public class TransactionListBalanceRequest : HttpRequestBase<TransactionListBalanceResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionListBalanceRequest"/> class with optional parameters for filtering the balance list.
    /// </summary>
    /// <param name="asOfTime">An optional string representing the as-of time for filtering balances. Must be between 20 and 64 characters in length.</param>
    /// <param name="currencyCode">An optional string representing the currency code for filtering balances. Must be exactly 3 characters in length.</param>
    public TransactionListBalanceRequest([StringLength(64, MinimumLength = 20)] string? asOfTime = null, [StringLength(3)] string? currencyCode = null) 
        : base(HttpMethod.Get, $"/v1/reporting/balances")
    {
        List<string> queryParams = [];
        if (!string.IsNullOrEmpty(asOfTime)) queryParams.Add($"as_of_time={asOfTime}");
        if (!string.IsNullOrEmpty(currencyCode)) queryParams.Add($"currency_code={currencyCode}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}