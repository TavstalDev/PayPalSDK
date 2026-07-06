using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The outcome code of a dispute resolution.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeOutcomeCode>))]
public enum EDisputeOutcomeCode
{
    /// <summary>
    /// Resolved in buyer's favor.
    /// </summary>
    RESOLVED_BUYER_FAVOUR = 0,
    /// <summary>
    /// Resolved in seller's favor.
    /// </summary>
    RESOLVED_SELLER_FAVOUR = 1,
    /// <summary>
    /// Resolved with a payout.
    /// </summary>
    RESOLVED_WITH_PAYOUT = 2,
    /// <summary>
    /// Canceled by the buyer.
    /// </summary>
    CANCELED_BY_BUYER = 3,
    /// <summary>
    /// The offer was accepted.
    /// </summary>
    ACCEPTED = 4,
    /// <summary>
    /// The operation was denied.
    /// </summary>
    DENIED = 5,
    /// <summary>
    /// No outcome code.
    /// </summary>
    NONE = 6
}
