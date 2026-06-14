using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to record a payment for an invoice.
/// </summary>
public class InvoiceRecordPaymentRequest: HttpRequestBase<InvoiceRecordPaymentBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceRecordPaymentRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice for which the payment is being recorded.</param>
    /// <param name="body">The payment details to record for the invoice.</param>
    public InvoiceRecordPaymentRequest(string invoiceId, InvoiceRecordPaymentRequestBody body) : base(HttpMethod.Post, $"/v2/invoicing/invoices/{invoiceId}/payments")
    {
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.InvoiceRecordPaymentRequestBody);
    }
}