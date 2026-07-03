using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to record an existing payment on an invoice by payment ID.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceRecordPaymentBody
{
    /// <summary>
    /// Gets or sets the payment identifier.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("payment_id")]
    [StringLength(22)]
    public string? PaymentId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}