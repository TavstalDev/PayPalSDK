using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeAcceptOfferRequestBody
{
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public required string Note { get; set; }
}