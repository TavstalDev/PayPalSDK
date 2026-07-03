using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the allowed response options in a PayPal dispute, including acknowledgment of return items, acceptance of claims, and making offers.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAllowedResponseOptions
{
    /// <summary>
    /// Gets or sets the acknowledgment return item details in the dispute, including the types of acknowledgments that can be made.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("acknowledge_return_item")]
    public DisputeAcknowledgeReturnItem? AcknowledgeReturnItem { get; set; }
    
    /// <summary>
    /// Gets or sets the claim acceptance details in the dispute, including the types of claims that can be accepted.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("accept_claim")]
    public DisputeAcceptClaim? AcceptClaim { get; set; }
    
    /// <summary>
    /// Gets or sets the offer-making details in the dispute, including the types of offers that can be made.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("make_offer")]
    public DisputeMakeOffer? MakeOffer { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}