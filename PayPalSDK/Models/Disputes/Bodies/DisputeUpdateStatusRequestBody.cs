using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeUpdateStatusRequestBody
{
    [JsonPropertyName("action")]
    [StringLength(255)]
    public required string Action { get; set; }
}