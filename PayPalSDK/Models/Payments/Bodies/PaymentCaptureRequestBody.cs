using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Payments.Bodies;

/// <summary>
/// Represents the body of a payment capture request.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentCaptureRequestBody
{
    /// <summary>
    /// The invoice ID associated with the payment capture.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// A note provided to the payer for the payment capture.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("note_to_payer")]
    [StringLength(255)]
    public string? NoteToPayer { get; set; }

    /// <summary>
    /// Indicates whether this is the final capture of the payment.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("final_capture")]
    public bool? FinalCapture { get; set; }

    /// <summary>
    /// Instructions for processing the payment.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction? PaymentInstruction { get; set; }

    /// <summary>
    /// A soft descriptor that appears on the payer's statement.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("soft_descriptor")]
    [StringLength(22)]
    public string? SoftDescriptor { get; set; }

    /// <summary>
    /// The monetary amount to be captured.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}