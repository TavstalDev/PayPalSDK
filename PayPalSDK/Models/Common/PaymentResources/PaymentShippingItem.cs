using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents a shipping item associated with a payment line item.
/// </summary>
public class PaymentShippingItem
{
    /// <summary>
    /// Gets or sets the shipping type.
    /// </summary>
    [JsonPropertyName("type")]
    [StringLength(32)]
    public required string Type { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping value.
    /// </summary>
    [JsonPropertyName("value")]
    [StringLength(20)]
    public required string Value { get; set; }
}