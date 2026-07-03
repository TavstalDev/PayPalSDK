using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents an item involved in a PayPal dispute, including details such as item ID, name, description, quantity, partner transaction ID, reason for dispute, notes, item type, and the disputed amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeItem
{
    /// <summary>
    /// Gets or sets the unique identifier for the disputed item. This property can be null and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("item_id")]
    [StringLength(255)]
    public string? ItemId { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the disputed item. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("item_name")]
    [StringLength(2000)]
    public string? ItemName { get; set; }
    
    /// <summary>
    /// Gets or sets the description of the disputed item. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("item_description")]
    [StringLength(2000)]
    public string? ItemDescription { get; set; }
    
    /// <summary>
    /// Gets or sets the quantity of the disputed item. This property can be null and has a maximum length of 10 characters.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("item_quantity")]
    [StringLength(10)]
    public string? ItemQuantity { get; set; }
    
    /// <summary>
    /// Gets or sets the partner transaction ID associated with the disputed item. This property can be null and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("partner_transaction_id")]
    [StringLength(255)]
    public string? PartnerTransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets the reason for the dispute. This property can be null and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    [StringLength(255)]
    public string? Reason { get; set; }
    
    /// <summary>
    /// Gets or sets additional notes related to the disputed item. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }
    
     /// <summary>
     /// Gets or sets the type of the disputed item. This property can be null, has a maximum length of 255 characters, and must match the specified regular expression pattern (only uppercase letters, digits, and underscores are allowed).
     /// </summary>
     [FluentMember(7)]
     [FluentSkippable]
     [JsonPropertyName("item_type")]
     [StringLength(255)]
     [RegularExpression("^[0-9A-Z_]+$")]
     public string? ItemType { get; set; }
     
     /// <summary>
     /// Gets or sets the amount disputed for the item. This property can be null and represents the monetary value of the dispute.
     /// </summary>
     [FluentMember(8)]
     [FluentSkippable]
     [JsonPropertyName("dispute_amount")]
     public Money? DisputeAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(9, "Build")]
    public void Build() { }
}