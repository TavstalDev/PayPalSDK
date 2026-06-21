using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the allowed response options in a PayPal dispute, including acknowledgment of return items, acceptance of claims, and making offers.
/// </summary>
[DataContract]
public class DisputeAllowedResponseOptions
{
    /// <summary>
    /// Gets or sets the acknowledgment return item details in the dispute, including the types of acknowledgments that can be made.
    /// </summary>
    [JsonPropertyName("acknowledge_return_item")]
    public DisputeAcknowledgeReturnItem? AcknowledgeReturnItem { get; set; }
    
    /// <summary>
    /// Gets or sets the claim acceptance details in the dispute, including the types of claims that can be accepted.
    /// </summary>
    [JsonPropertyName("accept_claim")]
    public DisputeAcceptClaim? AcceptClaim { get; set; }
    
    /// <summary>
    /// Gets or sets the offer-making details in the dispute, including the types of offers that can be made.
    /// </summary>
    [JsonPropertyName("make_offer")]
    public DisputeMakeOffer? MakeOffer { get; set; }
}