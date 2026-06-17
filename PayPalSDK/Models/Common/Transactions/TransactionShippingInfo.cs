using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionShippingInfo
{
    [JsonPropertyName("name")]
    [StringLength(500)]
    public string? Name { get; set; }
    
    [JsonPropertyName("method")]
    [StringLength(500)]
    public string? Method { get; set; }
    
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    [JsonPropertyName("secondary_shipping_address")]
    public Address? SecondaryShippingAddress { get; set; }
}