using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Invoices;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the payment terms for an invoice, including the type of term and the due date.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentTerm
{
    /// <summary>
    /// Gets or sets the type of payment term.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("term_type")]
    public EInvoicePaymentTerm? TermType { get; set; }

    /// <summary>
    /// Gets or sets the due date for the payment.
    /// </summary>
    /// <remarks>
    /// The due date must be in the format YYYY-MM-DD.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("due_date")]
    [StringLength(10)]
    [RegularExpression(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? DueDate { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}