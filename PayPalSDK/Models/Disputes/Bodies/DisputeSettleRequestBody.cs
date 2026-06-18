using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeSettleRequestBody
{
    [JsonPropertyName("adjudication_outcome")]
    [StringLength(255)]
    public required string AdjudicationOutcome { get; set; }
}