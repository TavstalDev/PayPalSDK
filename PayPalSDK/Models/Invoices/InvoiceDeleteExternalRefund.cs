using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP DELETE request to remove an external refund from an invoice.
/// </summary>
public class InvoiceDeleteExternalRefund: HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceDeleteExternalRefund"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice from which the refund should be removed.</param>
    /// <param name="transactionId">The identifier of the refund transaction to delete.</param>
    public InvoiceDeleteExternalRefund(string invoiceId, string transactionId) : base(HttpMethod.Delete, $"/v2/invoicing/invoices/{invoiceId}/refunds/{transactionId}")
    {
        // No body required
    }
}