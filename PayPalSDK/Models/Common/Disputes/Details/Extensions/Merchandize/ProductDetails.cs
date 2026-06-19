using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

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
    
    [JsonPropertyName("sub_reasons")]
    public List<string>? SubReasons { get; set; }
    
    [JsonPropertyName("purchase_url")]
    public string? PurchaseUrl { get; set; }
    
    [JsonPropertyName("product_received_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ProductReceivedTime { get; set; }
    
    [JsonPropertyName("expected_delivery_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? ExpectedDeliveryDate { get; set; }
    
    [JsonPropertyName("return_details")]
    public ReturnDetails? ReturnDetails { get; set; }
    
    public DateTime? ProducRecievedTimeAsDateTime => DateTimeHelper.FromISO8601(ProductReceivedTime);
    
    public DateTime? ExpectedDeliveryDateAsDateTime => DateTimeHelper.FromISO8601(ExpectedDeliveryDate);
}