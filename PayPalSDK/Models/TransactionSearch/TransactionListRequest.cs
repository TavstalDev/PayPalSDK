using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

namespace Tavstal.PayPalSDK.Models.TransactionSearch;

/// <summary>
/// Represents a request to retrieve a list of transactions, with optional filtering by various parameters such as date range, transaction ID, type, status, amount, currency, payment instrument type, store ID, and terminal ID. The request also allows specifying the fields to include in the response and pagination options.
/// </summary>
public class TransactionListRequest : HttpRequestBase<TransactionListResponseBody>
{
    /// <summary>
    /// Initializes a transaction search request for the PayPal Reporting Transactions API.
    /// </summary>
    /// <param name="startDate">
    /// The start of the transaction date range (inclusive), typically in RFC 3339 date-time format
    /// expected by PayPal (for example: <c>2024-01-01T00:00:00Z</c>).
    /// </param>
    /// <param name="endDate">
    /// The end of the transaction date range (inclusive), typically in RFC 3339 date-time format
    /// expected by PayPal (for example: <c>2024-01-31T23:59:59Z</c>).
    /// </param>
    /// <param name="transactionId">Optional PayPal transaction identifier used to filter results to a specific transaction.</param>
    /// <param name="transactionType">Optional transaction type filter (for example, payment or refund categories supported by PayPal).</param>
    /// <param name="transactionStatus">Optional transaction status filter (for example, completed, pending, denied).</param>
    /// <param name="transactionAmount">Optional transaction amount filter as a string, using the format accepted by the API.</param>
    /// <param name="transactionCurrency">Optional ISO-4217 currency code filter (for example: <c>USD</c>, <c>EUR</c>).</param>
    /// <param name="paymentInstrumentType">Optional payment instrument filter (for example, bank, card, or PayPal balance types).</param>
    /// <param name="storeId">Optional merchant store identifier to scope transactions to a specific store.</param>
    /// <param name="terminalId">Optional terminal identifier to scope transactions to a specific terminal/device.</param>
    /// <param name="fields">Comma-separated list of response field groups to include. Defaults to <c>transaction_info</c>.</param>
    /// <param name="balanceAffectingRecordsOnly">Indicates whether only balance-affecting records should be returned. Defaults to <c>Y</c>.</param>
    /// <param name="pageSize">Number of records per page. Defaults to <c>100</c>.</param>
    /// <param name="pageNumber">One-based page index to retrieve. Defaults to <c>1</c>.</param>
    public TransactionListRequest([StringLength(64, MinimumLength = 20)] string startDate, [StringLength(64, MinimumLength = 20)] string endDate, 
        [StringLength(19, MinimumLength = 17)] string? transactionId = null, string? transactionType  = null,
        string? transactionStatus  = null, string? transactionAmount  = null, string? transactionCurrency  = null, string? paymentInstrumentType  = null,
        string? storeId = null, string? terminalId = null, string fields = "transaction_info", 
        string balanceAffectingRecordsOnly = "Y", int pageSize = 100,  int pageNumber = 1) 
        : base(HttpMethod.Get, $"/v1/reporting/transactions")
    {
        List<string> queryParams = [
            $"start_date={startDate}",
            $"end_date={endDate}"
        ];
        if (!string.IsNullOrEmpty(transactionId)) queryParams.Add($"transaction_id={transactionId}");
        if (!string.IsNullOrEmpty(transactionType)) queryParams.Add($"transaction_type={transactionType}");
        if (!string.IsNullOrEmpty(transactionStatus)) queryParams.Add($"transaction_status={transactionStatus}");
        if (!string.IsNullOrEmpty(transactionAmount)) queryParams.Add($"transaction_amount={transactionAmount}");
        if (!string.IsNullOrEmpty(transactionCurrency)) queryParams.Add($"transaction_currency={transactionCurrency}");
        if (!string.IsNullOrEmpty(paymentInstrumentType)) queryParams.Add($"payment_instrument_type={paymentInstrumentType}");
        if (!string.IsNullOrEmpty(storeId)) queryParams.Add($"store_id={storeId}");
        if (!string.IsNullOrEmpty(terminalId)) queryParams.Add($"terminal_id={terminalId}");
        if  (!string.IsNullOrEmpty(fields)) queryParams.Add($"fields={fields}");
        if (!string.IsNullOrEmpty(balanceAffectingRecordsOnly)) queryParams.Add($"balance_affecting_records_only={balanceAffectingRecordsOnly}");
        if (pageSize != 100 && pageSize > 0) queryParams.Add($"page_size={pageSize}");
        if (pageNumber != 1 && pageNumber > 0) queryParams.Add($"page_number={pageNumber}");
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}