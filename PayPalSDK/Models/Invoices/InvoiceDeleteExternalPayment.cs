using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP DELETE request to remove an external payment from an invoice.
/// </summary>
public class InvoiceDeleteExternalPayment: HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceDeleteExternalPayment"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice from which the payment should be removed.</param>
    /// <param name="transactionId">The identifier of the payment transaction to delete.</param>
    public InvoiceDeleteExternalPayment(string invoiceId, string transactionId) : base(HttpMethod.Delete, $"/v2/invoicing/invoices/{invoiceId}/payments/{transactionId}")
    {
        // No body required
    }
}