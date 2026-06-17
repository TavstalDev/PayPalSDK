using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionStoreInfo
{
   [JsonPropertyName("store_id")]
   [StringLength(100)]
   public string? StoreId { get; set; }
   
   [JsonPropertyName("store_name")]
   [StringLength(60)]
   public string? StoreName { get; set; }
}