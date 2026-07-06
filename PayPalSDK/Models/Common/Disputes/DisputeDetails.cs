using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Disputes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents the full details of a PayPal dispute, including participants,
/// financial data, lifecycle state, evidence, and response options.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeDetails
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
    /// Gets or sets the transactions associated with the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("disputed_transactions")]
    public List<DisputedTransaction>? DisputedTransactions { get; set; }
    
    /// <summary>
    /// Gets or sets an external reason code provided by upstream systems.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("external_reason_code")]
    [StringLength(2000)]
    public string? ExternalReasonCode { get; set; }
    
    /// <summary>
    /// Gets or sets adjudication records created during dispute processing.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("adjudications")]
    public List<DisputeAdjudication>? Adjudications { get; set; }
    
    /// <summary>
    /// Gets or sets fund movement records related to the dispute.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("fund_movements")]
    public List<DisputeFundMovement>? FundMovements { get; set; }
    
    /// <summary>
    /// Gets or sets messages exchanged within the dispute conversation.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("messages")]
    public List<DisputeMessage>? Messages { get; set; }
    
    /// <summary>
    /// Gets or sets evidence submitted for the dispute.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
    
    /// <summary>
    /// Gets or sets additional supporting information attached to the dispute.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("supporting_info")]
    public List<DisputeSupportingInfo>? SupportingInfo { get; set; }
    
    /// <summary>
    /// Gets or sets HATEOAS links related to dispute operations.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute creation timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the most recent update timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the normalized reason code for the dispute.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    public EDisputeReason? Reason { get; set; }
    
    /// <summary>
    /// Gets or sets the current status code of the dispute.
    /// </summary>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EDisputeStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount currently in dispute.
    /// </summary>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("dispute_amount")]
    public Money? DisputeAmount { get; set; }
    
    /// <summary>
    /// Gets or sets asset-level details related to the disputed amount.
    /// </summary>
    [FluentMember(14)]
    [FluentSkippable]
    [JsonPropertyName("dispute_asset")]
    public Asset? DisputeAsset { get; set; }
    
    // TODO: Add fee_policy, It is an object but I can't find what should be in it.
    /*[JsonPropertyName("fee_policy")]
    [FluentMember(15)]
    [FluentSkippable]
    public object? FeePolicy { get; set; }*/
    
    /// <summary>
    /// Gets or sets the final or interim dispute outcome information.
    /// </summary>
    [FluentMember(16)]
    [FluentSkippable]
    [JsonPropertyName("dispute_outcome")]
    public DisputeOutcome? DisputeOutcome { get; set; }
    
    /// <summary>
    /// Gets or sets the dispute lifecycle stage code.
    /// </summary>
    [FluentMember(17)]
    [FluentSkippable]
    [JsonPropertyName("dispute_life_cycle_stage")]
    public EDisputeLifeCycleStage? LifeCycleStage { get; set; }
    
    /// <summary>
    /// Gets or sets the channel through which the dispute was initiated.
    /// </summary>
    [FluentMember(18)]
    [FluentSkippable]
    [JsonPropertyName("dispute_channel")]
    public EDisputeChannel? Channel { get; set; }
    
    /// <summary>
    /// Gets or sets additional dispute extension data.
    /// </summary>
    [FluentMember(19)]
    [FluentSkippable]
    [JsonPropertyName("extensions")]
    public DisputeExtensions? Extensions { get; set; }
    
    /// <summary>
    /// Gets or sets the buyer response due date in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(20)]
    [FluentSkippable]
    [JsonPropertyName("buyer_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? BuyerResponseDueDate { get; set; }
    
    /// <summary>
    /// Gets or sets the seller response due date in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(21)]
    [FluentSkippable]
    [JsonPropertyName("seller_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? SellerResponseDueDate { get; set; }
    
    /// <summary>
    /// Gets or sets the current offer details in the dispute flow.
    /// </summary>
    [FluentMember(22)]
    [FluentSkippable]
    [JsonPropertyName("offer")]
    public DisputeOffer? Offer { get; set; }
    
    /// <summary>
    /// Gets or sets refund information associated with the dispute.
    /// </summary>
    [FluentMember(23)]
    [FluentSkippable]
    [JsonPropertyName("refund_details")]
    public DisputeRefundDetails? RefundDetails { get; set; }
    
    /// <summary>
    /// Gets or sets communication metadata and conversation details for the dispute.
    /// </summary>
    [FluentMember(24)]
    [FluentSkippable]
    [JsonPropertyName("communication_details")]
    public DisputeCommunicationDetails? CommunicationDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the set of response actions currently available to the caller.
    /// </summary>
    [FluentMember(25)]
    [FluentSkippable]
    [JsonPropertyName("allowed_response_options")]
    public DisputeAllowedResponseOptions? AllowedResponseOptions { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(26, "Build")]
    public void Build() { }
}