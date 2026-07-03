using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the refund details in a PayPal dispute, including the list of transactions and the allowed refund amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeRefundDetails
{
    /// <summary>
    /// Gets or sets the list of transactions associated with the refund in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transactions")]
    public List<DisputeRefundTransaction>? Transactions { get; set; }
    
    /// <summary>
    /// Gets or sets the allowed refund amount for the dispute, if applicable.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("allowed_refund_amount")]
    public Money? AllowedRefundAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}