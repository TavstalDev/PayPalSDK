using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to generate the next available invoice number.
/// </summary>
public class InvoiceGenerateNumberRequest : HttpRequestBase<InvoiceGenerateNumberBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceGenerateNumberRequest"/> class.
    /// </summary>
    /// <param name="fetchId">Indicates whether the generated invoice number response should also include the invoice ID.</param>
    public InvoiceGenerateNumberRequest(bool fetchId = false) : base(HttpMethod.Post, $"/v2/invoicing/generate-next-invoice-number")
    {
        Content = JsonContent.Create(new InvoiceGenerateNumberRequestBody
        {
            FetchId = fetchId
        }, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}