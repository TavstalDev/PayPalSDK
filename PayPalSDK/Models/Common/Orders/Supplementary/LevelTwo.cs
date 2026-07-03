using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders.Supplementary;

/// <summary>
/// Represents Level 2 data for a PayPal order.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class LevelTwo
{
    /// <summary>
    /// Gets or sets the invoice ID associated with the transaction.
    /// </summary>
    /// <remarks>
    /// The invoice ID is a unique identifier for the transaction and is limited to 127 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Gets or sets the total tax amount for the transaction.
    /// </summary>
    /// <remarks>
    /// This property represents the monetary value of the tax applied to the transaction.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("tax_total")]
    public Money? TaxTotal { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}