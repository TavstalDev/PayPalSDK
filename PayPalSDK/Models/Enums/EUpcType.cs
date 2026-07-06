using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The type of UPC (Universal Product Code) barcode.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EUpcType>))]
public enum EUpcType
{
    /// <summary>
    /// Standard 12-digit UPC-A barcode.
    /// </summary>
    [JsonPropertyName("UPC-A")]
    UPC_A = 0,
    /// <summary>
    /// 12-digit UPC-B barcode for pharmaceutical products.
    /// </summary>
    [JsonPropertyName("UPC-B")]
    UPC_B = 1,
    /// <summary>
    /// 12-digit UPC-C barcode for health industry products.
    /// </summary>
    [JsonPropertyName("UPC-C")]
    UPC_C = 2,
    /// <summary>
    /// Variable-length UPC-D barcode for in-store use.
    /// </summary>
    [JsonPropertyName("UPC-D")]
    UPC_D = 3,
    /// <summary>
    /// 6-digit compressed UPC-E barcode.
    /// </summary>
    [JsonPropertyName("UPC_E")]
    UPC_E = 4,
    /// <summary>
    /// 2-digit supplemental UPC barcode.
    /// </summary>
    [JsonPropertyName("UPC_2")]
    UPC_2 = 5,
    /// <summary>
    /// 5-digit supplemental UPC barcode.
    /// </summary>
    [JsonPropertyName("UPC_5")]
    UPC_5 = 6
}
