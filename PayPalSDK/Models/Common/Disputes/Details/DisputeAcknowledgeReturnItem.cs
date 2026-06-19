using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents the acknowledgment return item in a PayPal dispute, including the types of acknowledgments that can be made.
/// </summary>
[DataContract]
public class DisputeAcknowledgeReturnItem
{
    /// <summary>
    /// Gets or sets the list of acknowledgment types that can be made for the return item in the dispute.
    /// </summary>
    [JsonPropertyName("acknowledgement_types")]
    public List<string>? AcknowledgementTypes { get; set; }
}