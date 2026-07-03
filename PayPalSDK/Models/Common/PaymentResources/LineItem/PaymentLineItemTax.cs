using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents tax information associated with a payment line item.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentLineItemTax
{
    /// <summary>
    /// Gets or sets the display name of the tax.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(127)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the type or category of the tax.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("type")]
    [StringLength(32)]
    public string? Type { get; set; }
    
    /// <summary>
    /// Gets or sets the tax value as a string representation.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("value")]
    [StringLength(20)]
    public string? Value { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}