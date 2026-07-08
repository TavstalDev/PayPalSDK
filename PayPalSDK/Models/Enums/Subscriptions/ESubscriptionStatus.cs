using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The status of a subscription.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ESubscriptionStatus>))]
public enum ESubscriptionStatus
{
    /// <summary>
    /// Subscription approval is pending.
    /// </summary>
    APPROVAL_PENDING = 0,
    /// <summary>
    /// The resource has been approved.
    /// </summary>
    APPROVED = 1,
    /// <summary>
    /// The subscription is active.
    /// </summary>
    ACTIVE = 2,
    /// <summary>
    /// The subscription is suspended.
    /// </summary>
    SUSPENDED = 3,
    /// <summary>
    /// The operation was canceled.
    /// </summary>
    CANCELLED = 4,
    /// <summary>
    /// The subscription has expired.
    /// </summary>
    EXPIRED = 5
}
