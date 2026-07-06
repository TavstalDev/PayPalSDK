using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// The disbursement mode for payments.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisbursementMode>))]
public enum EDisbursementMode
{
    /// <summary>Instant disbursement.</summary>
    INSTANT = 0,
    /// <summary>Delayed disbursement.</summary>
    DELAYED = 1
}
