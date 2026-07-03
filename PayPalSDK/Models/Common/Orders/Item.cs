using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Billing;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents an item in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Item
{
    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("name")]
    [StringLength(127)]
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 10 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("quantity")]
    [StringLength(10)]
    public string? Quantity { get; set; }

    /// <summary>
    /// Gets or sets the description of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(2048)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the stock keeping unit (SKU) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("sku")]
    [StringLength(127)]
    public string? Sku { get; set; }

    /// <summary>
    /// Gets or sets the URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("url")]
    [StringLength(2048)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the category of the item.
    /// </summary>
    /// <remarks>
    /// The category corresponds to one of the predefined item categories in <see cref="Tavstal.PayPalSDK.Constants.ItemCategory"/>.
    /// This field is optional and has a maximum length of 20 characters.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("category")]
    [StringLength(20)]
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the image URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("image_url")]
    [StringLength(2048)]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the unit amount of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the monetary value of the item.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("unit_amount")]
    public Money? UnitAmount { get; set; }

    /// <summary>
    /// Gets or sets the tax applied to the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the tax.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("tax")]
    public Money? Tax { get; set; }

    /// <summary>
    /// Gets or sets the Universal Product Code (UPC) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the UPC details.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("upc")]
    public UPC? UPC { get; set; }

    /// <summary>
    /// Gets or sets the billing plan associated with the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the billing plan details.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("billing_plan")]
    public BillingPlan? BillingPlan { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(11, "Build")]
    public void Build() { }
}