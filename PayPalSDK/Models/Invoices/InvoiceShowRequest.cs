using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP GET request to retrieve the details of a PayPal invoice by its unique identifier.
/// </summary>
public class InvoiceShowRequest : HttpRequestBase<InvoiceBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceShowRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The unique identifier of the invoice to retrieve.</param>
    public InvoiceShowRequest(string invoiceId)
        :
        base(HttpMethod.Get, $"/v2/invoicing/invoices/{invoiceId}")
    {
        // No content is set for a GET request.
    }
}