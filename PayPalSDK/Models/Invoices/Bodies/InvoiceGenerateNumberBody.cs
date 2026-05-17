using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to generate or assign an invoice number.
/// </summary>
[DataContract]
public class InvoiceGenerateNumberBody
{
    /// <summary>
    /// Gets or sets the invoice number.
    /// </summary>
    [JsonPropertyName("invoice_number")]
    [StringLength(25)]
    public string? InvoiceNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice identifier.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    [StringLength(24)]
    public string? InvoiceId { get; set; }
}