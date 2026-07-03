using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Payments.Bodies;

/// <summary>
/// Represents the body of a payment refund request.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentRefundRequestBody
{
    /// <summary>
    /// Gets or sets the custom identifier for the refund request.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("custom_id")]
    public string? CustomId { get; set; }

    /// <summary>
    /// Gets or sets the invoice identifier associated with the refund.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets a note to the payer regarding the refund.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("note_to_payer")]
    public string? NoteToPayer { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount to be refunded.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the payment instruction details for the refund.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction? PaymentInstruction { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}