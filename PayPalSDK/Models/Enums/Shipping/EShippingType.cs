using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The type of shipping fulfillment.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EShippingType>))]
public enum EShippingType
{
    /// <summary>Standard shipping fulfillment.</summary>
    SHIPPING = 0,
    /// <summary>In-person pickup fulfillment.</summary>
    PICKUP_IN_PERSON = 1,
    /// <summary>In-store pickup fulfillment.</summary>
    PICKUP_IN_STORE = 2,
    /// <summary>Pickup from a person.</summary>
    PICKUP_FROM_PERSON = 3
}
