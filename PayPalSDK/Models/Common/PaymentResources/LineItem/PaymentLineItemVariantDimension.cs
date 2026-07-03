using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents a variant dimension for a payment line item, such as size or color.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentLineItemVariantDimension
{
    /// <summary>
    /// Gets or sets the name of the variant dimension.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("name")]
    [StringLength(64)]
    [Required]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this is the primary variant dimension.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
    
    /// <summary>
    /// Gets or sets the available options for this variant dimension.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("options")]
    public List<PaymentLineItemVariantDimensionOption>? Options { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}