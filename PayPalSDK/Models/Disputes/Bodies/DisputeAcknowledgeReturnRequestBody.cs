using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeAcknowledgeReturnRequestBody
{
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
}