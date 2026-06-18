using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class DisputeItem
{
    [JsonPropertyName("item_id")]
    [StringLength(255)]
    public string? ItemId { get; set; }
    
    [JsonPropertyName("item_name")]
    [StringLength(2000)]
    public string? ItemName { get; set; }
    
    [JsonPropertyName("item_description")]
    [StringLength(2000)]
    public string? ItemDescription { get; set; }
    
    [JsonPropertyName("item_quantity")]
    [StringLength(10)]
    public string? ItemQuantity { get; set; }
    
    [JsonPropertyName("partner_transaction_id")]
    [StringLength(255)]
    public string? PartnerTransactionId { get; set; }
    
    [JsonPropertyName("reason")]
    [StringLength(255)]
    public string? Reason { get; set; }
    
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
     [JsonPropertyName("item_type")]
     [StringLength(255)]
     [RegularExpression("^[0-9A-Z_]+$")]
     public string? ItemType { get; set; }
     
     [JsonPropertyName("dispute_amount")]
     public Money? DisputeAmount { get; set; }
}