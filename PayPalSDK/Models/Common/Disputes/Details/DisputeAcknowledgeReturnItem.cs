using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the acknowledgment return item in a PayPal dispute, including the types of acknowledgments that can be made.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeAcknowledgeReturnItem
{
    /// <summary>
    /// Gets or sets the list of acknowledgment types that can be made for the return item in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("acknowledgement_types")]
    public List<string>? AcknowledgementTypes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}