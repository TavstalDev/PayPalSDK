using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents cart-related information for a transaction, including line items,
/// tax mode, and a merchant-provided PayPal invoice identifier.
/// </summary>
[DataContract]
public class TransactionCartInfo
{
   /// <summary>
   /// Gets or sets the collection of item-level details included in the transaction cart.
   /// </summary>
   [JsonPropertyName("item_details")]
   public List<TransactionItemDetail>? ItemDetails { get; set; }
   
   /// <summary>
   /// Gets or sets a value indicating whether item amounts are tax-inclusive.
   /// </summary>
   [JsonPropertyName("tax_inclusive")]
   public bool TaxInclusive { get; set; }
   
   /// <summary>
   /// Gets or sets the merchant invoice identifier associated with this cart/transaction.
   /// </summary>
   [JsonPropertyName("paypal_invoice_id")]
   [StringLength(127)]
   public string? PaypalInvoiceId { get; set; }
}