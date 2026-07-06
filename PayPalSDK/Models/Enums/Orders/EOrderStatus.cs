using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Orders;

/// <summary>
/// The status of an order.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EOrderStatus>))]
public enum EOrderStatus
{
    /// <summary>
    /// The resource has been created.
    /// </summary>
    CREATED = 0,
    /// <summary>
    /// The order has been saved.
    /// </summary>
    SAVED = 1,
    /// <summary>
    /// The resource has been approved.
    /// </summary>
    APPROVED = 2,
    /// <summary>
    /// The authorization was voided.
    /// </summary>
    VOIDED = 3,
    /// <summary>
    /// The operation completed successfully.
    /// </summary>
    COMPLETED = 4,
    /// <summary>
    /// Payer action is required to proceed.
    /// </summary>
    PAYER_ACTION_REQUIRED = 5
}
