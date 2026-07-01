using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents a monetary breakdown for an invoice, including item totals
/// and applied discounts.
/// </summary>
public class InvoiceBreakdown
{
    /// <summary>
    /// Gets or sets the total amount for all invoice line items before
    /// additional invoice-level calculations.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>item_total</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("item_total")]
    public Money? ItemTotal { get; set; }

    /// <summary>
    /// Gets or sets discount details applied to the invoice breakdown.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>discount</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("discount")]
    public InvoiceBreakdownDiscount? Discount { get; set; }
    
    /// <summary>
    /// Gets or sets the total tax amount applied to the invoice.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>tax_total</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("tax_total")]
    public Money? TaxTotal { get; set; }

    /// <summary>
    /// Gets or sets shipping-related breakdown details, including shipping
    /// amount and shipping tax.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>shipping</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("shipping")]
    public InvoiceBreakdownShipping? Shipping { get; set; }

    /// <summary>
    /// Gets or sets a custom breakdown entry for additional invoice charges
    /// or adjustments.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>custom</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("custom")]
    public InvoiceBreakdownCustom? Custom { get; set; }
}