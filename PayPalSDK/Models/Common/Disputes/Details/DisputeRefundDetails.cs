using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the refund details in a PayPal dispute, including the list of transactions and the allowed refund amount.
/// </summary>
public class DisputeRefundDetails
{
    /// <summary>
    /// Gets or sets the list of transactions associated with the refund in the dispute.
    /// </summary>
    [JsonPropertyName("transactions")]
    public List<DisputeRefundTransaction>? Transactions { get; set; }
    
    /// <summary>
    /// Gets or sets the allowed refund amount for the dispute, if applicable.
    /// </summary>
    [JsonPropertyName("allowed_refund_amount")]
    public Money? AllowedRefundAmount { get; set; }
}