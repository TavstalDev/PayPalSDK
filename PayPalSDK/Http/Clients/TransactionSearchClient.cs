using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.TransactionSearch;
using Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides access to PayPal Transaction Search endpoints, including transaction listing
/// and account balance retrieval.
/// </summary>
public class TransactionSearchClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of <see cref="TransactionSearchClient"/>.
    /// </summary>
    /// <param name="client">The HTTP client used to communicate with PayPal APIs.</param>
    public TransactionSearchClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Retrieves a paginated list of transactions for the given date range with optional filters.
    /// </summary>
    /// <param name="startDate">
    /// The beginning of the date range to search, typically in ISO-8601 format.
    /// </param>
    /// <param name="endDate">
    /// The end of the date range to search, typically in ISO-8601 format.
    /// </param>
    /// <param name="transactionId">Optional specific transaction ID to filter by.</param>
    /// <param name="transactionType">Optional transaction event code/type filter.</param>
    /// <param name="transactionStatus">Optional transaction status filter.</param>
    /// <param name="transactionAmount">Optional transaction amount filter.</param>
    /// <param name="transactionCurrency">Optional transaction currency code (for example, USD).</param>
    /// <param name="paymentInstrumentType">Optional payment instrument type filter.</param>
    /// <param name="storeId">Optional store identifier filter.</param>
    /// <param name="terminalId">Optional terminal identifier filter.</param>
    /// <param name="fields">
    /// Comma-separated response field groups to include. Defaults to <c>transaction_info</c>.
    /// </param>
    /// <param name="balanceAffectingRecordsOnly">
    /// Whether to return only balance-affecting records. Defaults to <c>Y</c>.
    /// </param>
    /// <param name="pageSize">The number of records per page. Defaults to <c>100</c>.</param>
    /// <param name="pageNumber">The page number to retrieve. Defaults to <c>1</c>.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess, TError}"/> containing <see cref="TransactionListResponseBody"/>
    /// on success, or <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<TransactionListResponseBody, ErrorResponse>> ListAsync(string startDate, string endDate,
        string? transactionId = null, string? transactionType = null, string? transactionStatus = null,
        string? transactionAmount = null, string? transactionCurrency = null, string? paymentInstrumentType = null,
        string? storeId = null, string? terminalId = null, string fields = "transaction_info",
        string balanceAffectingRecordsOnly = "Y", int pageSize = 100, int pageNumber = 1, CancellationToken cancellationToken = default)
    {
        var request = new TransactionListRequest(startDate, endDate, transactionId, transactionType, transactionStatus, transactionAmount, transactionCurrency, paymentInstrumentType, storeId, terminalId, fields, balanceAffectingRecordsOnly, pageSize, pageNumber);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves account balances, optionally filtered by timestamp and currency.
    /// </summary>
    /// <param name="asOfTime">
    /// Optional timestamp indicating the point-in-time balance snapshot, typically in ISO-8601 format.
    /// </param>
    /// <param name="currencyCode">
    /// Optional three-letter currency code to filter balances (for example, USD).
    /// </param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess, TError}"/> containing <see cref="TransactionListBalanceResponseBody"/>
    /// on success, or <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<TransactionListBalanceResponseBody, ErrorResponse>> ListBalancesAsync(string? asOfTime = null, string? currencyCode = null,
        CancellationToken cancellationToken = default)
    {
        var request = new TransactionListBalanceRequest();
        return await ExecuteAsync(request, cancellationToken);
    }
}