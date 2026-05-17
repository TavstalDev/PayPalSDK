using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to record a refund for an invoice.
/// </summary>
public class InvoiceRecordRefundRequest : HttpRequestBase<InvoiceRecordRefundBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceRecordRefundRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice for which the refund is being recorded.</param>
    /// <param name="body">The refund details to submit to the API.</param>
    public InvoiceRecordRefundRequest(string invoiceId, InvoiceRecordRefundRequestBody body) : base(HttpMethod.Post, $"v2/invoicing/invoices/{invoiceId}/refunds")
    {
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}