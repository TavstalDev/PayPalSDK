using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class DisputeDetails
{
    [JsonPropertyName("dispute_id")]
    [StringLength(255)]
    public string? DisputeId { get; set; }
    
    [JsonPropertyName("disputed_transactions")]
    public List<DisputedTransaction>? DisputedTransactions { get; set; }
    
    [JsonPropertyName("external_reason_code")]
    [StringLength(2000)]
    public string? ExternalReasonCode { get; set; }
    
    [JsonPropertyName("adjudications")]
    public List<DisputeAdjucation>? Adjudications { get; set; }
    
    [JsonPropertyName("fund_movements")]
    public List<DisputeFundMovement>? FundMovements { get; set; }
    
    [JsonPropertyName("messages")]
    public List<DisputeMessage>? Messages { get; set; }
    
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
    
    [JsonPropertyName("supporting_info")]
    public List<DisputeSupportingInfo>? SupportingInfo { get; set; }
    
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    [JsonPropertyName("update_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    [JsonPropertyName("reason")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Reason { get; set; }
    
    [JsonPropertyName("status")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Status { get; set; }
    
    [JsonPropertyName("dispute_amount")]
    public Money? DisputeAmount { get; set; }
    
    [JsonPropertyName("dispute_asset")]
    public Asset? DisputeAsset { get; set; }
    
    // TODO: Add fee_policy, It is an object but I can't find what should be in it.
    /*[JsonPropertyName("fee_policy")]
    public object? FeePolicy { get; set; }*/
    
    [JsonPropertyName("dispute_outcome")]
    public DisputeOutcome? DisputeOutcome { get; set; }
    
    [JsonPropertyName("dispute_life_cycle_stage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? LifeCycleStage { get; set; }
    
    [JsonPropertyName("dispute_channel")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Channel { get; set; }
    
    [JsonPropertyName("extensions")]
    public DisputeExtensions? Extensions { get; set; }
    
    [JsonPropertyName("buyer_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? BuyerResponseDueDate { get; set; }
    
    [JsonPropertyName("seller_response_due_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? SellerResponseDueDate { get; set; }
    
    [JsonPropertyName("offer")]
    public DisputeOffer? Offer { get; set; }
    
    [JsonPropertyName("refund_details")]
    public DisputeRefundDetails? RefundDetails { get; set; }
    
    [JsonPropertyName("communication_details")]
    public DisputeCommunicationDetails? CommunicationDetails { get; set; }
    
    [JsonPropertyName("allowed_response_options")]
    public DisputeAllowedResponseOptions? AllowedResponseOptions { get; set; }
}