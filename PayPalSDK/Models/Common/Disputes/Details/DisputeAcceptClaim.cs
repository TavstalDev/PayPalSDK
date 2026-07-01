using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the claim acceptance details in a PayPal dispute, including the types of claims that can be accepted.
/// </summary>
public class DisputeAcceptClaim
{
    /// <summary>
    /// Gets or sets the list of claim types that can be accepted in the dispute.
    /// </summary>
    [JsonPropertyName("accept_claim_types")]
    public List<string>? AcceptClaimTypes { get; set; }
}