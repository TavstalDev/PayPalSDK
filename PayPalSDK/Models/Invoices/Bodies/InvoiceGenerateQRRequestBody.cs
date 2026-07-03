using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for generating a QR code for an invoice, including the action to be performed and the dimensions of the QR code.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceGenerateQRRequestBody
{
    /// <summary>
    /// Gets or sets the QR code action to be performed when the code is scanned.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("action")]
    [Required]
    public string? Action { get; set; }

    /// <summary>
    /// Gets or sets the QR code width in pixels.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("width")] 
    public int Width { get; set; } = 500;

    /// <summary>
    /// Gets or sets the QR code height in pixels.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("height")] 
    public int Height { get; set; } = 500;

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}