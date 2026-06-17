using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionItemDetail
{
    [JsonPropertyName("item_code")]
    [StringLength(1000)]
    public string? ItemCode { get; set; }
    
    [JsonPropertyName("item_name")]
    [StringLength(200)]
    public string? ItemName { get; set; }
    
    [JsonPropertyName("item_description")]
    [StringLength(2000)]
    public string? ItemDescription { get; set; }
    
    [JsonPropertyName("item_options")]
    [StringLength(4000)]
    public string? ItemOptions { get; set; }
    
    [JsonPropertyName("item_quantity")]
    [StringLength(4000)]
    public string? ItemQuantity { get; set; }
    
    [JsonPropertyName("tax_amounts")]
    public List<TaxAmount>? TaxAmounts { get; set; }
    
    [JsonPropertyName("invoice_number")]
    [StringLength(200)]
    public string? InvoiceNumber { get; set; }
    
    [JsonPropertyName("checkout_options")]
    public List<CheckoutOption>? CheckoutOptions { get; set; }
    
    [JsonPropertyName("item_unit_price")]
    public Money? ItemUnitPrice { get; set; }
    
    [JsonPropertyName("item_amount")]
    public Money? ItemAmount { get; set; }
    
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }
    
    [JsonPropertyName("adjustment_amount")]
    public Money? AdjustmentAmount { get; set; }
    
    [JsonPropertyName("gift_wrap_amount")]
    public Money? GiftWrapAmount { get; set; }
    
    [JsonPropertyName("tax_percentage")]
    [StringLength(10)]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? TaxPercentage { get; set; }
    
    [JsonPropertyName("basic_shipping_amount")]
    public Money? BasicShippingAmount { get; set; }
    
    [JsonPropertyName("extra_shipping_amount")]
    public Money? ExtraShippingAmount { get; set; }
    
    [JsonPropertyName("handling_amount")]
    public Money? HandlingAmount { get; set; }
    
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; set; }
    
    [JsonPropertyName("total_item_amount")]
    public Money? TotalItemAmount { get; set; }
}