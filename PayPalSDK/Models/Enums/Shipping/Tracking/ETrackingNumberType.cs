using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping.Tracking;

/// <summary>
/// The type of tracking number.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ETrackingNumberType>))]
public enum ETrackingNumberType
{
    /// <summary>Tracking number provided by the carrier.</summary>
    CARRIER_PROVIDED = 0,
    /// <summary>Tracking number provided by an end-to-end partner.</summary>
    E2E_PARTNER_PROVIDED = 1
}
