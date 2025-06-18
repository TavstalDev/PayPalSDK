using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request for retrieving a list of PayPal invoices.
/// </summary>
public class InvoiceListRequest : HttpRequestBase<InvoiceListBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceListRequest"/> class.
    /// </summary>
    /// <param name="fields">Optional. Specifies the fields to include in the response.</param>
    /// <param name="page">The page number to retrieve. Defaults to 1.</param>
    /// <param name="pageSize">The number of invoices per page. Defaults to 20.</param>
    /// <param name="totalRequired">Indicates whether the total count of invoices is required in the response. Defaults to false.</param>
    public InvoiceListRequest(string? fields = null, int page = 1, int pageSize = 20, bool totalRequired = false)
        :
        base(HttpMethod.Get, $"/v2/invoicing/invoices?page={page}&page_size={pageSize}&total_required={totalRequired}{(fields != null ? $"&fields={fields}" : "")}")
    {
        // No body required
    }
}