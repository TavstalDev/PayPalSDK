using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents a selectable option for a payment line item variant dimension.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentLineItemVariantDimensionOption
{
    /// <summary>
    /// Gets or sets the display label for the variant option.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("label")]
    [StringLength(200)]
    [Required]
    public string? Label { get; set; }
    
    /// <summary>
    /// Gets or sets the unit amount associated with this variant option.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("unit_amount")]
    public Money? UnitAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}