using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents shipping-related charges in an invoice breakdown,
/// including the shipping amount and its tax details.
/// </summary>
[DataContract]
public class InvoiceBreakdownShipping
{
    /// <summary>
    /// Gets or sets the shipping charge amount.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>amount</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the tax applied to the shipping charge.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>tax</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("tax")]
    public Tax? Tax { get; set; }
}