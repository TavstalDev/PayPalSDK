using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents merchant store metadata associated with a transaction.
/// </summary>
public class TransactionStoreInfo
{
   /// <summary>
   /// Gets or sets the merchant-defined store identifier.
   /// </summary>
   [JsonPropertyName("store_id")]
   [StringLength(100)]
   public string? StoreId { get; set; }
   
   /// <summary>
   /// Gets or sets the display name of the store associated with the transaction.
   /// </summary>
   [JsonPropertyName("store_name")]
   [StringLength(60)]
   public string? StoreName { get; set; }
}