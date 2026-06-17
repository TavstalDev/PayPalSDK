using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionCartInfo
{
   [JsonPropertyName("item_details")]
   public List<TransactionItemDetail> ItemDetails { get; set; }
   
   [JsonPropertyName("tax_inclusive")]
   public bool TaxInclusive { get; set; }
   
   [JsonPropertyName("paypal_invoice_id")]
   [StringLength(127)]
   public string PaypalInvoiceId { get; set; }
}