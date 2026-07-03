using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents a monetary breakdown for an invoice, including item totals
/// and applied discounts.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceBreakdown
{
    /// <summary>
    /// Gets or sets the total amount for all invoice line items before
    /// additional invoice-level calculations.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>item_total</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("item_total")]
    public Money? ItemTotal { get; set; }

    /// <summary>
    /// Gets or sets discount details applied to the invoice breakdown.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>discount</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("discount")]
    public InvoiceBreakdownDiscount? Discount { get; set; }
    
    /// <summary>
    /// Gets or sets the total tax amount applied to the invoice.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>tax_total</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("tax_total")]
    public Money? TaxTotal { get; set; }

    /// <summary>
    /// Gets or sets shipping-related breakdown details, including shipping
    /// amount and shipping tax.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>shipping</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("shipping")]
    public InvoiceBreakdownShipping? Shipping { get; set; }

    /// <summary>
    /// Gets or sets a custom breakdown entry for additional invoice charges
    /// or adjustments.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>custom</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("custom")]
    public InvoiceBreakdownCustom? Custom { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}