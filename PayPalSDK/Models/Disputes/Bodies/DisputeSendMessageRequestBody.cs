using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeSendMessageRequestBody
{
    [JsonPropertyName("message")]
    [StringLength(2000)]
    public required string Message { get; set; }
}