using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

[DataContract]
public class DisputeMakeOffer
{
    [JsonPropertyName("offer_types")]
    public List<string>? OfferTypes { get; set; }
}