using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the breakdown of monetary amounts in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Breakdown
{
    /// <summary>
    /// Gets or sets the total amount for items.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the items.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("item_total")]
    [Required]
    public Money? ItemTotal { get; set; }

    /// <summary>
    /// Gets or sets the shipping amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of shipping.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("shipping")]
    public Money? Shipping { get; set; }

    /// <summary>
    /// Gets or sets the handling amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of handling.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("handling")]
    public Money? Handling { get; set; }

    /// <summary>
    /// Gets or sets the total tax amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of taxes.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("tax_total")]
    public Money? TaxTotal { get; set; }

    /// <summary>
    /// Gets or sets the insurance amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of insurance.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("insurance")]
    public Money? Insurance { get; set; }

    /// <summary>
    /// Gets or sets the shipping discount amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of shipping discounts.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("shipping_discount")]
    public Money? ShippingDiscount { get; set; }

    /// <summary>
    /// Gets or sets the discount amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of discounts.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("discount")]
    public Money? Discount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}