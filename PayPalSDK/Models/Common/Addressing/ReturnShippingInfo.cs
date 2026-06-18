using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

[DataContract]
public class ReturnShippingInfo
{
    [JsonPropertyName("save_to_profile")]
    public bool SaveToProfile { get; set; }
    
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
}