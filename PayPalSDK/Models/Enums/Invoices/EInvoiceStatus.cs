using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The status of an invoice.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EInvoiceStatus>))]
public enum EInvoiceStatus
{
    /// <summary>
    /// Invoice is in draft status.
    /// </summary>
    DRAFT = 0,
    /// <summary>
    /// Invoice has been sent.
    /// </summary>
    SENT = 1,
    /// <summary>
    /// Invoice is scheduled.
    /// </summary>
    SCHEDULED = 2,
    /// <summary>
    /// Invoice has been paid.
    /// </summary>
    PAID = 3,
    /// <summary>
    /// Invoice has been marked as paid.
    /// </summary>
    MARKED_AS_PAID = 4,
    /// <summary>
    /// The operation was canceled.
    /// </summary>
    CANCELLED = 5,
    /// <summary>
    /// The payment was refunded.
    /// </summary>
    REFUNDED = 6,
    /// <summary>
    /// Invoice is partially paid.
    /// </summary>
    PARTIALLY_PAID = 7,
    /// <summary>
    /// The payment was partially refunded.
    /// </summary>
    PARTIALLY_REFUNDED = 8,
    /// <summary>
    /// Invoice has been marked as refunded.
    /// </summary>
    MARKED_AS_REFUNDED = 9,
    /// <summary>
    /// Invoice is unpaid.
    /// </summary>
    UNPAID = 10,
    /// <summary>
    /// Invoice payment is pending.
    /// </summary>
    PAYMENT_PENDING = 11,
    /// <summary>
    /// Invoice was automatically canceled.
    /// </summary>
    AUTO_CANCELLED = 12,
    /// <summary>
    /// Invoice was paid externally.
    /// </summary>
    PAID_EXTERNAL = 13,
    /// <summary>
    /// Invoice was refunded externally.
    /// </summary>
    REFUNDED_EXTERNAL = 14,
    /// <summary>
    /// Invoice has been shared.
    /// </summary>
    SHARED = 15
}
