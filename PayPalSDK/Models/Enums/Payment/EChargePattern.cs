using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The charge pattern for a payment, describing when and how charges occur.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EChargePattern>))]
public enum EChargePattern
{
    /// <summary>
    /// Immediate value.
    /// </summary>
    IMMEDIATE = 0,
    /// <summary>
    /// Deferred value.
    /// </summary>
    DEFERRED = 1,
    /// <summary>
    /// Recurring Prepaid value.
    /// </summary>
    RECURRING_PREPAID = 2,
    /// <summary>
    /// Recurring Postpaid value.
    /// </summary>
    RECURRING_POSTPAID = 3,
    /// <summary>
    /// Threshold Prepaid value.
    /// </summary>
    THRESHOLD_PREPAID = 4,
    /// <summary>
    /// Threshold Postpaid value.
    /// </summary>
    THRESHOLD_POSTPAID = 5,
    /// <summary>
    /// Subscription Prepaid value.
    /// </summary>
    SUBSCRIPTION_PREPAID = 6,
    /// <summary>
    /// Subscription Postpaid value.
    /// </summary>
    SUBSCRIPTION_POSTPAID = 7,
    /// <summary>
    /// Unscheduled Prepaid value.
    /// </summary>
    UNSCHEDULED_PREPAID = 8,
    /// <summary>
    /// Unscheduled Postpaid value.
    /// </summary>
    UNSCHEDULED_POSTPAID = 9,
    /// <summary>
    /// Installment Prepaid value.
    /// </summary>
    INSTALLMENT_PREPAID = 10,
    /// <summary>
    /// Installment Postpaid value.
    /// </summary>
    INSTALLMENT_POSTPAID = 11
}
