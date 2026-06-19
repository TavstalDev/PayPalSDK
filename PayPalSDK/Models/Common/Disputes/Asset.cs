using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

[DataContract]
public class Asset
{
    [JsonPropertyName("asset_symbol")]
    [StringLength(10)]
    [RegularExpression("^[0-9A-Za-z]{1,10}$")]
    public required string AssetSymbol { get; set; }
    
    [JsonPropertyName("quantity")]
    [StringLength(40)]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public required string Quantity { get; set; }
    
    [JsonPropertyName("quantity_in_subunits")]
    [StringLength(81)]
    [RegularExpression("^-?[0-9]+$")]
    public string? QuantityInSubunits { get; set; }
    
    [JsonPropertyName("decimals")]
    public int Decimals { get; set; }
}