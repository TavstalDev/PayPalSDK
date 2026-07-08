using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The status of a disputed transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeTransactionStatus>))]
public enum EDisputeTransactionStatus
{
    /// <summary>
    /// The operation completed successfully.
    /// </summary>
    COMPLETED = 0,
    /// <summary>
    /// Unclaimed value.
    /// </summary>
    UNCLAIMED = 1,
    /// <summary>
    /// The operation was denied.
    /// </summary>
    DENIED = 2,
    /// <summary>
    /// The operation failed.
    /// </summary>
    FAILED = 3,
    /// <summary>
    /// Held value.
    /// </summary>
    HELD = 4,
    /// <summary>
    /// The operation is pending.
    /// </summary>
    PENDING = 5,
    /// <summary>
    /// The payment was partially refunded.
    /// </summary>
    PARTIALLY_REFUNDED = 6,
    /// <summary>
    /// The payment was refunded.
    /// </summary>
    REFUNDED = 7,
    /// <summary>
    /// Reversed value.
    /// </summary>
    REVERSED = 8,
    /// <summary>
    /// The operation was canceled.
    /// </summary>
    CANCELLED = 9
}
