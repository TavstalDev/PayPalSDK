using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents a non-fiat asset amount used in dispute-related responses.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Asset
{
    /// <summary>
    /// Gets or sets the asset symbol (for example, a ticker-like identifier).
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("asset_symbol")]
    [StringLength(10)]
    [RegularExpression("^[0-9A-Za-z]{1,10}$")]
    [Required]
    public string? AssetSymbol { get; set; }
    
    /// <summary>
    /// Gets or sets the human-readable asset quantity as a decimal string.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("quantity")]
    [StringLength(40)]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? Quantity { get; set; }
    
    /// <summary>
    /// Gets or sets the asset quantity expressed in the smallest subunits.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("quantity_in_subunits")]
    [StringLength(81)]
    [RegularExpression("^-?[0-9]+$")]
    public string? QuantityInSubunits { get; set; }
    
    /// <summary>
    /// Gets or sets the number of decimal places supported by the asset.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("decimals")]
    public int Decimals { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}