using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for generating the next available invoice number, with an option to fetch the invoice ID.
/// </summary>
public class InvoiceGenerateNumberRequestBody
{
    /// <summary>
    /// Gets or sets a value indicating whether the generated invoice number response should also include the invoice ID.
    /// </summary>
    [JsonPropertyName("fetch_id")]
    public bool FetchId { get; set; }
}