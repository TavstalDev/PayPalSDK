using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeAcceptClaim
{
    [JsonPropertyName("accept_claim_types")]
    public List<string>? AcceptClaimTypes { get; set; }
}