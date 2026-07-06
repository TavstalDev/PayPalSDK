using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Billing;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Invoices;

namespace Tavstal.PayPalSDK.Models.Common.Orders.Supplementary;

/// <summary>
/// Represents a line item in a PayPal order.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class LineItem
{
    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    /// <remarks>
    /// The name is a required field and is limited to 127 characters.
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
    /// The quantity is a required field and is limited to 10 characters.
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
    /// The description is optional and is limited to 2048 characters.
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
    /// The SKU is optional and is limited to 127 characters.
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
    /// The URL is optional and is limited to 2048 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("url")]
    [StringLength(2048)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the image URL of the item.
    /// </summary>
    /// <remarks>
    /// The image URL is optional and is limited to 2048 characters.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("image_url")]
    [StringLength(2048)]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the Universal Product Code (UPC) of the item.
    /// </summary>
    /// <remarks>
    /// The UPC is optional and provides a standardized identifier for the item.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("upc")]
    public UPC? UPC { get; set; }

    /// <summary>
    /// Gets or sets the billing plan associated with the item.
    /// </summary>
    /// <remarks>
    /// The billing plan is optional and defines payment terms for the item.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("billing_plan")]
    public BillingPlan? BillingPlan { get; set; }

    /// <summary>
    /// Gets or sets the commodity code of the item.
    /// </summary>
    /// <remarks>
    /// The commodity code is optional and is limited to 12 characters.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("commidity_code")]
    [StringLength(12)]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Gets or sets the unit of measure for the item.
    /// </summary>
    /// <remarks>
    /// The unit of measure is optional.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("unit_of_measure")]
    public EMeasureUnit? UnitOfMeasure { get; set; }

    /// <summary>
    /// Gets or sets the unit amount for the item.
    /// </summary>
    /// <remarks>
    /// The unit amount is a required field and represents the monetary value of a single unit.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("unit_amount")]
    public Money? UnitAmount { get; set; }

    /// <summary>
    /// Gets or sets the tax amount for the item.
    /// </summary>
    /// <remarks>
    /// The tax amount is optional and represents the monetary value of the tax applied to the item.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("tax")]
    public Money? Tax { get; set; }

    /// <summary>
    /// Gets or sets the discount amount for the item.
    /// </summary>
    /// <remarks>
    /// The discount amount is optional and represents the monetary value of any discounts applied to the item.
    /// </remarks>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }

    /// <summary>
    /// Gets or sets the total amount for the item.
    /// </summary>
    /// <remarks>
    /// The total amount is optional and represents the monetary value of the item after applying taxes and discounts.
    /// </remarks>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("total_amount")]
    public Money? TotalAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(14, "Build")]
    public void Build() { }
}