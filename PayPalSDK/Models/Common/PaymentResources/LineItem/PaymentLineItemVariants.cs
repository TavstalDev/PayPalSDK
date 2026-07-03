using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents the variant configuration for a payment line item.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentLineItemVariants
{
    /// <summary>
    /// Gets or sets the collection of variant dimensions available for the line item.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("dimensions")]
    public List<PaymentLineItemVariantDimension>? Dimensions { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}