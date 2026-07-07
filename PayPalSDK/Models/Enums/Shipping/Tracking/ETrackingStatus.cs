using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping.Tracking;

/// <summary>
/// The tracking status of a shipment.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ETrackingStatus>))]
public enum ETrackingStatus
{
    /// <summary>
    /// The operation was canceled.
    /// </summary>
    CANCELLED = 0,
    /// <summary>
    /// Delivered value.
    /// </summary>
    DELIVERED = 1,
    /// <summary>
    /// Local pickup tracking status.
    /// </summary>
    LOCAL_PICKUP = 2,
    /// <summary>
    /// Shipment is on hold.
    /// </summary>
    ON_HOLD = 3,
    /// <summary>
    /// Return shipped back.
    /// </summary>
    SHIPPED = 4,
    /// <summary>
    /// Shipment has been created.
    /// </summary>
    SHIPMENT_CREATED = 5,
    /// <summary>
    /// Shipment has been dropped off.
    /// </summary>
    DROPPED_OFF = 6,
    /// <summary>
    /// Shipment is in transit.
    /// </summary>
    IN_TRANSIT = 7,
    /// <summary>
    /// Shipment has been returned.
    /// </summary>
    RETURNED = 8,
    /// <summary>
    /// Shipping label has been printed.
    /// </summary>
    LABEL_PRINTED = 9,
    /// <summary>
    /// An error occurred with tracking.
    /// </summary>
    ERROR = 10,
    /// <summary>
    /// Tracking is unconfirmed.
    /// </summary>
    UNCONFIRMED = 11,
    /// <summary>
    /// Pickup failed.
    /// </summary>
    PICKUP_FAILED = 12,
    /// <summary>
    /// Delivery is delayed.
    /// </summary>
    DELIVERY_DELAYED = 13,
    /// <summary>
    /// Delivery is scheduled.
    /// </summary>
    DELIVERY_SCHEDULED = 14,
    /// <summary>
    /// Delivery failed.
    /// </summary>
    DELIVERY_FAILED = 15,
    /// <summary>
    /// Shipment is being returned.
    /// </summary>
    INRETURN = 16,
    /// <summary>
    /// Shipment is in process.
    /// </summary>
    IN_PROCESS = 17,
    /// <summary>
    /// New tracking entry.
    /// </summary>
    NEW = 18,
    /// <summary>
    /// Tracking has been voided.
    /// </summary>
    VOID = 19,
    /// <summary>
    /// Tracking has been processed.
    /// </summary>
    PROCESSED = 20,
    /// <summary>
    /// Item has not been shipped.
    /// </summary>
    NOT_SHIPPED = 21,
    /// <summary>
    /// The operation completed successfully.
    /// </summary>
    COMPLETED = 22
}
