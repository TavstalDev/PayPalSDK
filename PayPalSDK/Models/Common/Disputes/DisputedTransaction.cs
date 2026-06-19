using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class DisputedTransaction
{
    [JsonPropertyName("buyer_transaction_id")]
    [StringLength(255)]
    public string? BuyerTransactionId { get; set; }
    
    [JsonPropertyName("seller_transaction_id")]
    [StringLength(255)]
    public string? SellerTransactionId { get; set; }
    
    [JsonPropertyName("reference_id")]
    [StringLength(255)]
    public string? ReferenceId { get; set; }
    
    [JsonPropertyName("transaction_status")]
    [StringLength(255)]
    public string? TransactionStatus { get; set; }
    
    [JsonPropertyName("invoice_number")]
    [StringLength(127)]
    public string? InvoiceNumber { get; set; }
    
    [JsonPropertyName("custom")]
    [StringLength(2000)]
    public string? Custom { get; set; }
    
    [JsonPropertyName("items")]
    public List<DisputeItem>? Items { get; set; }
    
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    [JsonPropertyName("gross_amount")]
    public Money? GrossAmount { get; set; }
    
    [JsonPropertyName("gross_asset")]
    public Asset? GrossAsset { get; set; }
    
    [JsonPropertyName("buyer")]
    public Buyer? Buyer { get; set; }
    
    [JsonPropertyName("seller")]
    public Seller? Seller { get; set; }
    
    public DateTime? CreateTimeAsDateTime => DateTimeHelper.FromISO8601(CreateTime);
}