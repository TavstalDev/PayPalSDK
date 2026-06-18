using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeAllowedResponseOptions
{
    [JsonPropertyName("acknowledge_return_item")]
    public DisputeAcknowledgeReturnItem? AcknowledgeReturnItem { get; set; }
    
    [JsonPropertyName("accept_claim")]
    public DisputeAcceptClaim? AcceptClaim { get; set; }
    
    [JsonPropertyName("make_offer")]
    public DisputeMakeOffer? MakeOffer { get; set; }
}