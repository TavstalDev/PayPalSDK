using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a refund associated with a PayPal invoice, including transactions and the total refund amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceRefund
{
    /// <summary>
    /// Gets or sets the list of transactions related to the invoice refund.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transactions")]
    public List<InvoiceRefundTransaction>? Transactions { get; set; }

    /// <summary>
    /// Gets or sets the total amount refunded for the invoice.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("refund_amount")]
    public Money? RefundAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}