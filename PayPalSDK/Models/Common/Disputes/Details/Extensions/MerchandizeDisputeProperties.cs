using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

[DataContract]
public class MerchandizeDisputeProperties
{
    [JsonPropertyName("issue_type")]
    [StringLength(255)]
    public string? IssueType { get; set; }
    
    [JsonPropertyName("product_details")]
    public ProductDetails? ProductDetails { get; set; }
    
    [JsonPropertyName("service_details")]
    public ServiceDetails? ServiceDetails { get; set; }
    
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
    
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
}