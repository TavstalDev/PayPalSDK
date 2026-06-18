using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

[DataContract]
public class ProductDetails
{
    [JsonPropertyName("description")]
    [StringLength(2000)]
    public string? Description { get; set; }
    
    [JsonPropertyName("product_received")]
    [StringLength(255)]
    public string? ProductReceived { get; set; }
    
    // TODO: Implement
}