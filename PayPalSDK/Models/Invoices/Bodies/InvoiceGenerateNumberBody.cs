using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to generate or assign an invoice number.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceGenerateNumberBody
{
    /// <summary>
    /// Gets or sets the invoice number.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("invoice_number")]
    [StringLength(25)]
    public string? InvoiceNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice identifier.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(24)]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}