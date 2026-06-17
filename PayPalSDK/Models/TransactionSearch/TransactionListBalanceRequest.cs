using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.TransactionSearch;

// TODO: Add return value
public class TransactionListBalanceRequest : HttpRequestBase
{
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