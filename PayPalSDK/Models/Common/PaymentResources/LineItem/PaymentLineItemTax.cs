using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents tax information associated with a payment line item.
/// </summary>
public class PaymentLineItemTax
{
    /// <summary>
    /// Gets or sets the display name of the tax.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(127)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the type or category of the tax.
    /// </summary>
    [JsonPropertyName("type")]
    [StringLength(32)]
    public required string Type { get; set; }
    
    /// <summary>
    /// Gets or sets the tax value as a string representation.
    /// </summary>
    [JsonPropertyName("value")]
    [StringLength(20)]
    public required string Value { get; set; }
}