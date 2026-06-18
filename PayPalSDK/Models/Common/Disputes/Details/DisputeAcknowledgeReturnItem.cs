using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeAcknowledgeReturnItem
{
    [JsonPropertyName("acknowledgement_types")]
    public List<string>? AcknowledgementTypes { get; set; }
}