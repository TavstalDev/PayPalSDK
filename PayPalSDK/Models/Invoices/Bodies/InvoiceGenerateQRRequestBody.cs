using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for generating a QR code for an invoice, including the action to be performed and the dimensions of the QR code.
/// </summary>
public class InvoiceGenerateQRRequestBody
{
    /// <summary>
    /// Gets or sets the QR code action to be performed when the code is scanned.
    /// </summary>
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    /// <summary>
    /// Gets or sets the QR code width in pixels.
    /// </summary>
    [JsonPropertyName("width")] 
    public int Width { get; set; } = 500;

    /// <summary>
    /// Gets or sets the QR code height in pixels.
    /// </summary>
    [JsonPropertyName("height")] 
    public int Height { get; set; } = 500;
}