using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the claim acceptance details in a PayPal dispute, including the types of claims that can be accepted.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAcceptClaim
{
    /// <summary>
    /// Gets or sets the list of claim types that can be accepted in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("accept_claim_types")]
    public List<string>? AcceptClaimTypes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}