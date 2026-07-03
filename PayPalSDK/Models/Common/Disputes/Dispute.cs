using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents a dispute summary record returned by the disputes API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Dispute
{
    /// <summary>
    /// Gets or sets the unique identifier of the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("dispute_id")]
    [StringLength(255)]
    public string? DisputeId { get; set; }
    
    /// <summary>
    /// Gets or sets related HATEOAS links for dispute operations.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute creation timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the last update timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute reason code.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Reason { get; set; }
    
    /// <summary>
    /// Gets or sets the current dispute status code.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the broader dispute state classification.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("dispute_state")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? DisputeState { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount currently in dispute.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("dispute_amount")]
    public Money? DisputeAmount { get; set; }
    
    /// <summary>
    /// Gets or sets asset-level details associated with the disputed amount.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("dispute_asset")]
    public Asset? DisputeAsset { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute lifecycle stage code.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("dispute_life_cycle_stage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? LifeCycleStage { get; set; }
    
    /// <summary>
    /// Gets or sets the channel through which the dispute was raised.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("dispute_channel")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? DisputeChannel { get; set; }
    
    /// <summary>
    /// Gets or sets the buyer response due date in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("buyer_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? BuyerResponseDueDate { get; set; }
    
    /// <summary>
    /// Gets or sets the seller response due date in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("seller_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? SellerResponseDueDate { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(13, "Build")]
    public void Build() { }
}