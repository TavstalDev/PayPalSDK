using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to generate a QR code for an invoice.
/// </summary>
public class InvoiceGenerateQRRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceGenerateQRRequest"/> class.
    /// </summary>
    /// <param name="invoiceId">The identifier of the invoice for which the QR code should be generated.</param>
    /// <param name="action">The QR code action to encode. Defaults to <c>"pay"</c>.</param>
    /// <param name="width">The width of the generated QR code image in pixels. Defaults to <c>500</c>.</param>
    /// <param name="height">The height of the generated QR code image in pixels. Defaults to <c>500</c>.</param>
    public InvoiceGenerateQRRequest(string invoiceId, string action = "pay", int width = 500, int height = 500) : base(HttpMethod.Post, 
        $"/v2/invoicing/invoices/{invoiceId}/generate-qr-code")
    {
        Content = JsonContent.Create(new InvoiceGenerateQRRequestBody
        {
            Action = action,
            Width = width,
            Height = height
        }, PayPalSDKJsonContext.Default.InvoiceGenerateQRRequestBody);
    }
}