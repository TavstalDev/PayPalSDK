using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// Represents the CaptureStatus type.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECaptureStatus>))]
public enum ECaptureStatus
{
    /// <summary>
    /// The operation completed successfully.
    /// </summary>
    COMPLETED = 0,
    /// <summary>
    /// The operation was declined.
    /// </summary>
    DECLINED = 1,
    /// <summary>
    /// The payment was partially refunded.
    /// </summary>
    PARTIALLY_REFUNDED = 2,
    /// <summary>
    /// The operation is pending.
    /// </summary>
    PENDING = 3,
    /// <summary>
    /// The payment was refunded.
    /// </summary>
    REFUNDED = 4,
    /// <summary>
    /// The operation failed.
    /// </summary>
    FAILED = 5
}
