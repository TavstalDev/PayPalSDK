using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

namespace Tavstal.PayPalSDK.Models.TransactionSearch;

public class TransactionListRequest : HttpRequestBase<TransactionListResponseBody>
{
    public TransactionListRequest([StringLength(64, MinimumLength = 20)] string startDate, [StringLength(64, MinimumLength = 20)] string endDate, 
        [StringLength(19, MinimumLength = 17)] string? transactionId = null, string? transactionType  = null,
        string? transactionStatus  = null, string? transactionAmount  = null, string? transactionCurrency  = null, string? paymentInstrumentType  = null,
        string? storeId = null, string? terminalId = null, string fields = "transaction_info", 
        string balanceAffectingRecordsOnly = "Y", int pageSize = 100,  int pageNumber = 1) 
        : base(HttpMethod.Get, $"/v1/reporting/transactions")
    {
        List<string> queryParams = [
            $"start_date={startDate}",
            $"end_date={endDate}," +
            $"fields={fields}",
            $"balance_affecting_records_only={balanceAffectingRecordsOnly}",
            $"page_size={pageSize}",
            $"page_number={pageNumber}"
        ];
        if (!string.IsNullOrEmpty(transactionId)) queryParams.Add($"transaction_id={transactionId}");
        if (!string.IsNullOrEmpty(transactionType)) queryParams.Add($"transaction_type={transactionType}");
        if (!string.IsNullOrEmpty(transactionStatus)) queryParams.Add($"transaction_status={transactionStatus}");
        if (!string.IsNullOrEmpty(transactionAmount)) queryParams.Add($"transaction_amount={transactionAmount}");
        if (!string.IsNullOrEmpty(transactionCurrency)) queryParams.Add($"transaction_currency={transactionCurrency}");
        if (!string.IsNullOrEmpty(paymentInstrumentType)) queryParams.Add($"payment_instrument_type={paymentInstrumentType}");
        if (!string.IsNullOrEmpty(storeId)) queryParams.Add($"store_id={storeId}");
        if (!string.IsNullOrEmpty(terminalId)) queryParams.Add($"terminal_id={terminalId}");
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}