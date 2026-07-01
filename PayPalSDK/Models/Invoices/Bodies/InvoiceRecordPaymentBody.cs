using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to record an existing payment on an invoice by payment ID.
/// </summary>
public class InvoiceRecordPaymentBody
{
    /// <summary>
    /// Gets or sets the payment identifier.
    /// </summary>
    [JsonPropertyName("payment_id")]
    [StringLength(22)]
    public string? PaymentId { get; set; }
}