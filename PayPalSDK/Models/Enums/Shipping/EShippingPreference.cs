using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The shipping address preference for checkout.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EShippingPreference>))]
public enum EShippingPreference
{
    /// <summary>Shipping address retrieved from file.</summary>
    GET_FROM_FILE = 0,
    /// <summary>No shipping required.</summary>
    NO_SHIPPING = 1,
    /// <summary>Use the provided shipping address.</summary>
    SET_PROVIDED_ADDRESS = 2
}
