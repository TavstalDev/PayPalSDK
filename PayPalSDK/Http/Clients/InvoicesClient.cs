using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating, sending, updating, and managing PayPal invoices.
/// </summary>
public sealed class InvoicesClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoicesClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public InvoicesClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a draft invoice.
    /// </summary>
    /// <param name="body">The draft invoice payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="InvoiceBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceBody, ErrorResponse>> CreateDraftAsync(InvoiceCreateDraftRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceCreateDraftRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves an invoice by its identifier.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the requested <see cref="InvoiceBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceBody, ErrorResponse>> ShowAsync(string invoiceId,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceShowRequest(invoiceId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Sends an invoice to recipients.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The send request payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing a <see cref="Link"/> to related resource metadata on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<Link, ErrorResponse>> SendAsync(string invoiceId, InvoiceSendRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceSendRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists invoices with optional field selection and paging controls.
    /// </summary>
    /// <param name="fields">Optional comma-separated fields to include in each invoice item.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="pageSize">The number of records per page.</param>
    /// <param name="totalRequired">Whether to include total count metadata in the response.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="InvoiceListBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceListBody, ErrorResponse>> ListAsync(string? fields = null, int page = 1, int pageSize = 20, bool totalRequired = false, 
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceListRequest(fields, page, pageSize, totalRequired);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates an existing invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The invoice update payload.</param>
    /// <param name="sendToRecipient">Whether the update should trigger notification to the recipient.</param>
    /// <param name="sendToInvoicer">Whether the update should trigger notification to the invoicer.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the updated <see cref="InvoiceBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceBody, ErrorResponse>> UpdateAsync(string invoiceId, InvoiceUpdateRequestBody body, bool sendToRecipient = true, bool sendToInvoicer = true,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceUpdateRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Records an external payment against an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The payment record payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="InvoiceRecordPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceRecordPaymentBody, ErrorResponse>> RecordPaymentAsync(string invoiceId, InvoiceRecordPaymentRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceRecordPaymentRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Records an external refund against an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The refund record payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="InvoiceRecordRefundBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceRecordRefundBody, ErrorResponse>> RecordRefundAsync(string invoiceId,
        InvoiceRecordRefundRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new InvoiceRecordRefundRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Sends a reminder for an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The reminder payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> SendReminderAsync(string invoiceId, InvoiceSendReminderRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceSendReminderRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Cancels an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="body">The cancel request payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> CancelAsync(string invoiceId,
        InvoiceCancelRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new InvoiceCancelRequest(invoiceId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Deletes an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteAsync(string invoiceId,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceDeleteRequest(invoiceId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Deletes an externally recorded payment from an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="paymentId">The external payment identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteExternalPaymentAsync(string invoiceId, string paymentId,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceDeleteExternalPaymentRequest(invoiceId, paymentId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Deletes an externally recorded refund from an invoice.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="refundId">The external refund identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteExternalRefundAsync(string invoiceId, string refundId,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceDeleteExternalRefundRequest(invoiceId, refundId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Generates the next available invoice number.
    /// </summary>
    /// <param name="fetchId">Whether to also fetch an internal identifier with the generated number.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="InvoiceGenerateNumberBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceGenerateNumberBody, ErrorResponse>> GenerateNumberAsync(bool fetchId = false, CancellationToken cancellationToken = default)
    {
        var request = new InvoiceGenerateNumberRequest(fetchId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Searches invoices using paging and optional structured query filters.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="pageSize">The number of records per page.</param>
    /// <param name="totalRequired">Whether to include total count metadata in the response.</param>
    /// <param name="body">Optional search criteria payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="InvoiceSearchBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<InvoiceSearchBody, ErrorResponse>> SearchAsync(int page = 1, int pageSize = 10, bool totalRequired = false, InvoiceListRequestBody? body = null,
        CancellationToken cancellationToken = default)
    {
        var request = new InvoiceSearchRequest(page, pageSize, totalRequired, body);
        return await ExecuteAsync(request, cancellationToken);
    }
}