using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents a customer note definition attached to a payment resource.
/// </summary>
public class CustomerNote
{
    /// <summary>
    /// Gets or sets a value indicating whether the note is required.
    /// </summary>
    [JsonPropertyName("required")]
    public bool Required { get; set; }
    
    /// <summary>
    /// Gets or sets the label shown for the customer note field.
    /// </summary>
    [JsonPropertyName("label")]
    [StringLength(127)]
    public string? Label { get; set; }
}