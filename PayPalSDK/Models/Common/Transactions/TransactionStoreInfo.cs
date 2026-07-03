using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents merchant store metadata associated with a transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionStoreInfo
{
   /// <summary>
   /// Gets or sets the merchant-defined store identifier.
   /// </summary>
   [FluentMember(0)]
   [FluentSkippable]
   [JsonPropertyName("store_id")]
   [StringLength(100)]
   public string? StoreId { get; set; }
   
   /// <summary>
   /// Gets or sets the display name of the store associated with the transaction.
   /// </summary>
   [FluentMember(1)]
   [FluentSkippable]
   [JsonPropertyName("store_name")]
   [StringLength(60)]
   public string? StoreName { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}