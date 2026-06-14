using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to cancel an invoice in the PayPal Invoicing API.
/// </summary>
public class InvoiceCancelRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceCancelRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice to cancel.</param>
    /// <param name="body">The cancellation options and recipient settings for the request.</param>
    public InvoiceCancelRequest(string invoiceId, InvoiceCancelRequestBody body) : base(HttpMethod.Post, $"/v2/invoicing/invoices/{invoiceId}/cancel")
    {
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.InvoiceCancelRequestBody);
    }
}