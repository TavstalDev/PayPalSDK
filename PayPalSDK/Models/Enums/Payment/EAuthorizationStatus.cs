using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The status of a payment authorization.
/// </summary>
/// <remarks>Possible values: CREATED, CAPTURED, DENIED, PARTIALLY_CAPTURED, VOIDED, PENDING</remarks>
[JsonConverter(typeof(JsonStringEnumConverter<EAuthorizationStatus>))]
public enum EAuthorizationStatus
{
    /// <summary>
    /// The resource has been created.
    /// </summary>
    CREATED = 0,
    /// <summary>
    /// Captured value.
    /// </summary>
    CAPTURED = 1,
    /// <summary>
    /// The operation was denied.
    /// </summary>
    DENIED = 2,
    /// <summary>
    /// The payment was partially captured.
    /// </summary>
    PARTIALLY_CAPTURED = 3,
    /// <summary>
    /// The authorization was voided.
    /// </summary>
    VOIDED = 4,
    /// <summary>
    /// The operation is pending.
    /// </summary>
    PENDING = 5
}
