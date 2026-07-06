using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The direction of shipping.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EShippingDirection>))]
public enum EShippingDirection
{
    /// <summary>Forward shipping direction.</summary>
    FORWARD = 0,
    /// <summary>Return shipping direction.</summary>
    RETURN = 1
}
