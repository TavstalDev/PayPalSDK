using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of item involved in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeItemType>))]
public enum EDisputeItemType
{
    /// <summary>Product-related issue.</summary>
    PRODUCT = 0,
    /// <summary>Service-related issue.</summary>
    SERVICE = 1,
    /// <summary>Booking item type.</summary>
    BOOKING = 2,
    /// <summary>Digital download item type.</summary>
    DIGITAL_DOWNLOAD = 3
}
