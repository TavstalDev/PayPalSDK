using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents display preferences for a specific invoice field.
/// </summary>
public class InvoiceFieldDisplayPreference
{
    /// <summary>
    /// Gets or sets a value indicating whether the associated invoice field
    /// is hidden from display.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>hidden</c> in the PayPal invoice payload.
    /// </remarks>
    [JsonPropertyName("hidden")]
    public bool Hidden { get; set; }
}