using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

[DataContract]
public class ServiceDetails
{
    [JsonPropertyName("description")]
    [StringLength(2000)]
    public string? Description { get; set; }
    
    [JsonPropertyName("service_started")]
    [StringLength(255)]
    public string? ServiceStarted { get; set; }
    
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    [JsonPropertyName("sub_reasons")]
    public List<string>? SubReasons { get; set; }
    
    [JsonPropertyName("purchase_url")]
    public string? PurchaseUrl { get; set; }
}