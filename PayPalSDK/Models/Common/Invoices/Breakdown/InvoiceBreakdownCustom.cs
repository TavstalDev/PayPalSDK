using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;

/// <summary>
/// Represents a custom invoice breakdown line, defined by a user-provided label
/// and an associated monetary amount.
/// </summary>
[DataContract]
public class InvoiceBreakdownCustom
{
    /// <summary>
    /// Gets or sets the custom label for this breakdown entry.
    /// </summary>
    /// <remarks>
    /// This property is required and serialized as <c>label</c>.
    /// Maximum length is 50 characters.
    /// </remarks>
    [JsonPropertyName("label")]
    [StringLength(50)]
    public required string Label { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount associated with the custom label.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>amount</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
}