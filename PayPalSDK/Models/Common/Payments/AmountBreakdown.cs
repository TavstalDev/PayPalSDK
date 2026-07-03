using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the breakdown of an amount in a transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class AmountBreakdown
{
    /// <summary>
    /// Gets or sets the gross amount of the transaction.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("gross_amount")]
    [Required]
    public Money? GrossAmount { get; set; }

    /// <summary>
    /// Gets or sets the total item amount in the transaction.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_item_amount")]
    public Money? TotalItemAmount { get; set; }

    /// <summary>
    /// Gets or sets the fee amount associated with the transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("fee_amount")]
    public Money? FeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the shipping amount for the transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("shipping_amount")]
    public Money? ShippingAmount { get; set; }

    /// <summary>
    /// Gets or sets the tax amount for the transaction.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("tax_amount")]
    public Money? TaxAmount { get; set; }

    /// <summary>
    /// Gets or sets the net amount of the transaction after deductions.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("net_amount")]
    public Money? NetAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}