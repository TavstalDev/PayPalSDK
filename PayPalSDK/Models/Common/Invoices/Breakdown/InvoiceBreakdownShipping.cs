using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents shipping-related charges in an invoice breakdown,
/// including the shipping amount and its tax details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceBreakdownShipping
{
    /// <summary>
    /// Gets or sets the shipping charge amount.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>amount</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the tax applied to the shipping charge.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>tax</c> in the PayPal invoice payload.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("tax")]
    public Tax? Tax { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}