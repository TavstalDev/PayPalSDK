using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The reason for a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeReason>))]
public enum EDisputeReason
{
    /// <summary>
    /// Merchandise Or Service Not Received value.
    /// </summary>
    MERCHANDISE_OR_SERVICE_NOT_RECEIVED = 0,
    /// <summary>
    /// Merchandise Or Service Not As Described value.
    /// </summary>
    MERCHANDISE_OR_SERVICE_NOT_AS_DESCRIBED = 1,
    /// <summary>
    /// Unauthorised value.
    /// </summary>
    UNAUTHORISED = 2,
    /// <summary>
    /// Credit Not Processed value.
    /// </summary>
    CREDIT_NOT_PROCESSED = 3,
    /// <summary>
    /// Duplicate Transaction value.
    /// </summary>
    DUPLICATE_TRANSACTION = 4,
    /// <summary>
    /// Incorrect Amount value.
    /// </summary>
    INCORRECT_AMOUNT = 5,
    /// <summary>
    /// Payment By Other Means value.
    /// </summary>
    PAYMENT_BY_OTHER_MEANS = 6,
    /// <summary>
    /// Canceled Recurring Billing value.
    /// </summary>
    CANCELED_RECURRING_BILLING = 7,
    /// <summary>
    /// Problem With Remittance value.
    /// </summary>
    PROBLEM_WITH_REMITTANCE = 8,
    /// <summary>
    /// Other payment method or reason.
    /// </summary>
    OTHER = 9
}
