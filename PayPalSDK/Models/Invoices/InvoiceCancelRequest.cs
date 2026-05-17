using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to cancel an invoice in the PayPal Invoicing API.
/// </summary>
public class InvoiceCancelRequest : HttpRequestBase<InvoiceListBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceCancelRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice to cancel.</param>
    /// <param name="body">The cancellation options and recipient settings for the request.</param>
    public InvoiceCancelRequest(string invoiceId, InvoiceCancelRequestBody body) : base(HttpMethod.Post, $"/v2/invoicing/invoices/{invoiceId}/cancel")
    {
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}