using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents a selectable option for a payment line item variant dimension.
/// </summary>
[DataContract]
public class PaymentLineItemVariantDimensionOption
{
    /// <summary>
    /// Gets or sets the display label for the variant option.
    /// </summary>
    [JsonPropertyName("label")]
    [StringLength(200)]
    public required string Label { get; set; }
    
    /// <summary>
    /// Gets or sets the unit amount associated with this variant option.
    /// </summary>
    [JsonPropertyName("unit_amount")]
    public Money? UnitAmount { get; set; }
}