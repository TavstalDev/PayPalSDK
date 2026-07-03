using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents the adjustable quantity settings for a payment line item.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentLineItemAdjustableQuantity
{
    /// <summary>
    /// Gets or sets the maximum quantity allowed for the line item.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("maximum")]
    [Required]
    public int? Maximum { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}