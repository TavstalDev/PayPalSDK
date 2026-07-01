using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents a non-fiat asset amount used in dispute-related responses.
/// </summary>
public class Asset
{
    /// <summary>
    /// Gets or sets the asset symbol (for example, a ticker-like identifier).
    /// </summary>
    [JsonPropertyName("asset_symbol")]
    [StringLength(10)]
    [RegularExpression("^[0-9A-Za-z]{1,10}$")]
    public required string AssetSymbol { get; set; }
    
    /// <summary>
    /// Gets or sets the human-readable asset quantity as a decimal string.
    /// </summary>
    [JsonPropertyName("quantity")]
    [StringLength(40)]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public required string Quantity { get; set; }
    
    /// <summary>
    /// Gets or sets the asset quantity expressed in the smallest subunits.
    /// </summary>
    [JsonPropertyName("quantity_in_subunits")]
    [StringLength(81)]
    [RegularExpression("^-?[0-9]+$")]
    public string? QuantityInSubunits { get; set; }
    
    /// <summary>
    /// Gets or sets the number of decimal places supported by the asset.
    /// </summary>
    [JsonPropertyName("decimals")]
    public int Decimals { get; set; }
}