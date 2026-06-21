using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents discount amounts in an invoice breakdown, including
/// overall invoice-level discounts and aggregated item-level discounts.
/// </summary>
[DataContract]
public class InvoiceBreakdownDiscount
{
    /// <summary>
    /// Gets or sets the discount applied at the invoice level.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>invoice_discount</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("invoice_discount")]
    public InvoiceDiscount? InvoiceDiscount { get; set; }

    /// <summary>
    /// Gets or sets the total discount applied across individual line items.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>item_discount</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("item_discount")]
    public Money? ItemDiscount { get; set; }
}