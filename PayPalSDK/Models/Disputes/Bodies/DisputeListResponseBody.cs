using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeListResponseBody
{
    [JsonPropertyName("items")]
    public List<Dispute>? Items { get; set; }
    
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}