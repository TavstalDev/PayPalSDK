using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a percentage value used in invoice-related models.
/// </summary>
public class TipPreset
{
    /// <summary>
    /// Gets or sets the percentage value.
    /// </summary>
    [JsonPropertyName("percent")]
    [StringLength(20)]
    public string? Percent { get; set; }
}