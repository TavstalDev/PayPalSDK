using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request for deleting a PayPal invoice.
/// </summary>
public class InvoiceDeleteRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceDeleteRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The unique identifier of the invoice to be deleted.</param>
    public InvoiceDeleteRequest(string invoiceId)
        :
        base(HttpMethod.Delete, $"/v2/invoicing/invoices/{invoiceId}")
    {
        // No body is required
    }
}