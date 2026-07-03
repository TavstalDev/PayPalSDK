using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents a shipping item associated with a payment line item.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentShippingItem
{
    /// <summary>
    /// Gets or sets the shipping type.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("type")]
    [StringLength(32)]
    [Required]
    public string? Type { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping value.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("value")]
    [StringLength(20)]
    public string? Value { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}