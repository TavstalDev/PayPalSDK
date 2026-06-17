using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents a single line-item within transaction cart details, including
/// product metadata, quantity, taxes, checkout options, and amount breakdowns.
/// </summary>
[DataContract]
public class TransactionItemDetail
{
    /// <summary>
    /// Gets or sets the merchant item code or SKU.
    /// </summary>
    [JsonPropertyName("item_code")]
    [StringLength(1000)]
    public string? ItemCode { get; set; }
    
    /// <summary>
    /// Gets or sets the display name of the item.
    /// </summary>
    [JsonPropertyName("item_name")]
    [StringLength(200)]
    public string? ItemName { get; set; }
    
    /// <summary>
    /// Gets or sets a detailed description of the item.
    /// </summary>
    [JsonPropertyName("item_description")]
    [StringLength(2000)]
    public string? ItemDescription { get; set; }
    
    /// <summary>
    /// Gets or sets option data selected for the item (for example size, color, or variants).
    /// </summary>
    [JsonPropertyName("item_options")]
    [StringLength(4000)]
    public string? ItemOptions { get; set; }
    
    /// <summary>
    /// Gets or sets the item quantity as provided by the API payload.
    /// </summary>
    [JsonPropertyName("item_quantity")]
    [StringLength(4000)]
    public string? ItemQuantity { get; set; }
    
    /// <summary>
    /// Gets or sets tax amount entries applied to this item.
    /// </summary>
    [JsonPropertyName("tax_amounts")]
    public List<TaxAmount>? TaxAmounts { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice number associated with this item.
    /// </summary>
    [JsonPropertyName("invoice_number")]
    [StringLength(200)]
    public string? InvoiceNumber { get; set; }
    
    /// <summary>
    /// Gets or sets checkout option key/value pairs recorded for this item.
    /// </summary>
    [JsonPropertyName("checkout_options")]
    public List<CheckoutOption>? CheckoutOptions { get; set; }
    
    /// <summary>
    /// Gets or sets the per-unit price of the item.
    /// </summary>
    [JsonPropertyName("item_unit_price")]
    public Money? ItemUnitPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the base item amount before additional adjustments.
    /// </summary>
    [JsonPropertyName("item_amount")]
    public Money? ItemAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the discount amount applied to this item.
    /// </summary>
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets an adjustment amount applied to the item.
    /// </summary>
    [JsonPropertyName("adjustment_amount")]
    public Money? AdjustmentAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the gift-wrap amount charged for the item.
    /// </summary>
    [JsonPropertyName("gift_wrap_amount")]
    public Money? GiftWrapAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the tax percentage for this item as a numeric string.
    /// </summary>
    [JsonPropertyName("tax_percentage")]
    [StringLength(10)]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? TaxPercentage { get; set; }
    
    /// <summary>
    /// Gets or sets the standard shipping amount allocated to this item.
    /// </summary>
    [JsonPropertyName("basic_shipping_amount")]
    public Money? BasicShippingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets any extra shipping amount allocated to this item.
    /// </summary>
    [JsonPropertyName("extra_shipping_amount")]
    public Money? ExtraShippingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the handling amount charged for this item.
    /// </summary>
    [JsonPropertyName("handling_amount")]
    public Money? HandlingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the insurance amount charged for this item.
    /// </summary>
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the final total amount for the item after applied components.
    /// </summary>
    [JsonPropertyName("total_item_amount")]
    public Money? TotalItemAmount { get; set; }
}