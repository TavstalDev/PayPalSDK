using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents a variant dimension for a payment line item, such as size or color.
/// </summary>
[DataContract]
public class PaymentLineItemVariantDimension
{
    /// <summary>
    /// Gets or sets the name of the variant dimension.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(64)]
    public required string Name { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether this is the primary variant dimension.
    /// </summary>
    [JsonPropertyName("primary")]
    public required bool Primary { get; set; }
    
    /// <summary>
    /// Gets or sets the available options for this variant dimension.
    /// </summary>
    [JsonPropertyName("options")]
    public List<PaymentLineItemVariantDimensionOption>? Options { get; set; }
}