using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The type of shipping cost calculation.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EShippingCostType>))]
public enum EShippingCostType
{
    /// <summary>Flat shipping cost.</summary>
    FLAT = 0,
    /// <summary>Tax calculated as a percentage.</summary>
    PERCENTAGE = 1,
    /// <summary>Combined tax setting.</summary>
    PREFERENCE = 2
}
