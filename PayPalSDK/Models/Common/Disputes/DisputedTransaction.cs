using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents transaction details associated with a dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputedTransaction
{
    /// <summary>
    /// Gets or sets the transaction identifier as seen by the buyer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("buyer_transaction_id")]
    [StringLength(255)]
    public string? BuyerTransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction identifier as seen by the seller.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("seller_transaction_id")]
    [StringLength(255)]
    public string? SellerTransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets the external reference identifier associated with the transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("reference_id")]
    [StringLength(255)]
    public string? ReferenceId { get; set; }
    
    /// <summary>
    /// Gets or sets the status of the disputed transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("transaction_status")]
    public EDisputeTransactionStatus? TransactionStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice number linked to the transaction.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("invoice_number")]
    [StringLength(127)]
    public string? InvoiceNumber { get; set; }
    
    /// <summary>
    /// Gets or sets custom merchant data associated with the transaction.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("custom")]
    [StringLength(2000)]
    public string? Custom { get; set; }
    
    /// <summary>
    /// Gets or sets the line items included in the disputed transaction.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<DisputeItem>? Items { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction creation timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the total disputed amount for the transaction.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("gross_amount")]
    public Money? GrossAmount { get; set; }
    
    /// <summary>
    /// Gets or sets asset-level details related to the transaction amount.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("gross_asset")]
    public Asset? GrossAsset { get; set; }
    
    /// <summary>
    /// Gets or sets buyer information associated with the transaction.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("buyer")]
    public Buyer? Buyer { get; set; }
    
    /// <summary>
    /// Gets or sets seller information associated with the transaction.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("seller")]
    public Seller? Seller { get; set; }
    
    /// <summary>
    /// Gets the <see cref="CreateTime"/> value parsed as a <see cref="DateTime"/>, if valid.
    /// </summary>
    public DateTime? CreateTimeAsDateTime => DateTimeHelper.FromISO8601(CreateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(12, "Build")]
    public void Build() { }
}