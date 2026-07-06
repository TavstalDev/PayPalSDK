using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Products;

/// <summary>
/// The type of product.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EProductType>))]
public enum EProductType
{
    /// <summary>Physical product type.</summary>
    PHYSICAL = 0,
    /// <summary>Digital product type.</summary>
    DIGITAL = 1,
    /// <summary>Service-related issue.</summary>
    SERVICE = 2
}
