using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The status of a refund transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ERefundStatus>))]
public enum ERefundStatus
{
    /// <summary>The operation was cancelled.</summary>
    CANCELLED = 0,
    /// <summary>The operation failed.</summary>
    FAILED = 1,
    /// <summary>The operation is pending.</summary>
    PENDING = 2,
    /// <summary>The operation completed successfully.</summary>
    COMPLETED = 3
}
