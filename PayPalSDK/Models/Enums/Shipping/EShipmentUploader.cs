using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The entity that uploaded shipping information.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EShipmentUploader>))]
public enum EShipmentUploader
{
    /// <summary>Payment initiated by the merchant.</summary>
    MERCHANT = 0,
    /// <summary>Consumer value.</summary>
    CONSUMER = 1,
    /// <summary>Partner value.</summary>
    PARTNER = 2
}
