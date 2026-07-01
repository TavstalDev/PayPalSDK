using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents a payment line item, including pricing, shipping, taxes, and quantity options.
/// </summary>
public class PaymentLineItem
{
  /// <summary>
  /// Gets or sets the line item name.
  /// </summary>
  [JsonPropertyName("name")]
  [StringLength(127)]
  public string? Name { get; set; }
  
  /// <summary>
  /// Gets or sets the line item description.
  /// </summary>
  [JsonPropertyName("description")]
  [StringLength(2048)]
  public string? Description { get; set; }
  
  /// <summary>
  /// Gets or sets the list of applicable taxes for this line item.
  /// </summary>
  [JsonPropertyName("taxes")]
  public List<PaymentLineItemTax>? Taxes { get; set; }
  
  /// <summary>
  /// Gets or sets the shipping entries associated with this line item.
  /// </summary>
  [JsonPropertyName("shipping")]
  public List<PaymentShippingItem>? Shipping { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether a shipping address should be collected.
  /// </summary>
  [JsonPropertyName("collect_shipping_address")]
  public bool CollectShippingAddress { get; set; }
  
  /// <summary>
  /// Gets or sets customer notes associated with this line item.
  /// </summary>
  [JsonPropertyName("customer_notes")]
  public List<CustomerNote>? CustomerNotes { get; set; }
  
  /// <summary>
  /// Gets or sets the unit amount for this line item.
  /// </summary>
  [JsonPropertyName("unit_amount")]
  public Money? UnitAmount { get; set; }
  
  /// <summary>
  /// Gets or sets the available variants for this line item.
  /// </summary>
  [JsonPropertyName("variants")]
  public PaymentLineItemVariants? Variants { get; set; }
  
  /// <summary>
  /// Gets or sets the adjustable quantity settings for this line item.
  /// </summary>
  [JsonPropertyName("adjustable_quantity")]
  public PaymentLineItemAdjustableQuantity? AdjustableQuantity { get; set; }
}