using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents the payment details for a PayPal invoice, including transactions and the total paid amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoicePayment
{
    /// <summary>
    /// Gets or sets the list of transactions associated with the invoice payment.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transactions")]
    public List<InvoiceTransaction>? Transactions { get; set; }

    /// <summary>
    /// Gets or sets the total amount paid for the invoice.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("paid_amount")]
    public Money? PaidAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}