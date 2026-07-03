using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents cart-related information for a transaction, including line items,
/// tax mode, and a merchant-provided PayPal invoice identifier.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionCartInfo
{
   /// <summary>
   /// Gets or sets the collection of item-level details included in the transaction cart.
   /// </summary>
   [FluentMember(0)]
   [FluentSkippable]
   [JsonPropertyName("item_details")]
   public List<TransactionItemDetail>? ItemDetails { get; set; }
   
   /// <summary>
   /// Gets or sets a value indicating whether item amounts are tax-inclusive.
   /// </summary>
   [FluentMember(1)]
   [FluentSkippable]
   [JsonPropertyName("tax_inclusive")]
   public bool TaxInclusive { get; set; }
   
   /// <summary>
   /// Gets or sets the merchant invoice identifier associated with this cart/transaction.
   /// </summary>
   [FluentMember(2)]
   [FluentSkippable]
   [JsonPropertyName("paypal_invoice_id")]
   [StringLength(127)]
   public string? PaypalInvoiceId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}