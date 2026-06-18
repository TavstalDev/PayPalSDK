using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

[DataContract]
public class DisputeAppealRequestBody
{
    [JsonPropertyName("evidences")]
    public List<Evidence>? Evidences { get; set; }
    
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
    
    [JsonPropertyName("return_shipping_address_info")]
    public ReturnShippingInfo? ReturnShippingAddressInfo { get; set; }
}