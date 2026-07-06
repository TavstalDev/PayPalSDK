using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Invoices;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents the configuration options for an invoice, including tax calculation, tipping, partial payments, and template selection.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceConfig
{
    /// <summary>
    /// Gets or sets a value indicating whether tax is calculated after discounts are applied.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("tax_calculated_after_discount")]
    public bool TaxCalculatedAfterDiscount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the tax is inclusive in the invoice amounts.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("tax_inclusive")]
    public bool TaxInclusive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether tipping is allowed on the invoice.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("allow_tip")]
    public bool AllowTip { get; set; }

    /// <summary>
    /// Gets or sets the partial payment options for the invoice.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("partial_payment")]
    public PartialPayment? PartialPayment { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether conditional rules are enabled for the invoice configuration.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("has_conditional_rule")]
    public bool HasConditionalRule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether invoice items are saved for future reuse.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("save_item_for_future")]
    public bool SaveItemForFuture { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether additional item fields are displayed in the invoice.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("show_additional_item_fields")]
    public bool ShowAdditionalItemFields { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the preferred discount mode behavior for the invoice.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("discount_mode_preference")]
    public EDiscountModePreference? DiscountModePreference { get; set; }

    /// <summary>
    /// Gets or sets the visual theme configuration applied to the invoice.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("theme")]
    public InvoiceTheme? Theme { get; set; }
    
    /// <summary>
    /// Gets or sets the template ID used for the invoice.
    /// </summary>
    /// <remarks>
    /// The template ID must not exceed 30 characters.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("template_id")]
    [StringLength(30)]
    public string? TemplateId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(10, "Build")]
    public void Build() { }
}