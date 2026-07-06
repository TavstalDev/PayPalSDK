using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Invoices;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents an item in an invoice.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceItem
{
    /// <summary>
    /// Gets or sets the name of the invoice item.
    /// </summary>
    /// <remarks>
    /// The name must not exceed 200 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("name")]
    [StringLength(200)]
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the invoice item.
    /// </summary>
    /// <remarks>
    /// The description must not exceed 1000 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(1000)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the invoice item.
    /// </summary>
    /// <remarks>
    /// The quantity must not exceed 14 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("quantity")]
    [StringLength(14)]
    public string? Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit amount of the invoice item.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("unit_amount")]
    public Money? UnitAmount { get; set; }

    /// <summary>
    /// Gets or sets the tax information for the invoice item.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("tax")]
    public Tax? Tax { get; set; }

    /// <summary>
    /// Gets or sets the date of the invoice item.
    /// </summary>
    /// <remarks>
    /// The date must be in the format YYYY-MM-DD.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("item_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? ItemDate { get; set; }

    /// <summary>
    /// Gets or sets the discount applied to the invoice item.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("discount")]
    public Discount? Discount { get; set; }

    /// <summary>
    /// Gets or sets the unit of measure for the invoice item.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("unit_of_measure")]
    public EMeasureUnit? UnitOfMeasure { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}