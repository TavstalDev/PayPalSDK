using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The status of a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeStatus>))]
public enum EDisputeStatus
{
    /// <summary>
    /// The dispute is open.
    /// </summary>
    OPEN = 0,
    /// <summary>
    /// Waiting for the buyer to respond.
    /// </summary>
    WAITING_FOR_BUYER_RESPONSE = 1,
    /// <summary>
    /// Waiting for the seller to respond.
    /// </summary>
    WAITING_FOR_SELLER_RESPONSE = 2,
    /// <summary>
    /// The dispute is under review.
    /// </summary>
    UNDER_REVIEW = 3,
    /// <summary>
    /// The dispute has been resolved.
    /// </summary>
    RESOLVED = 4,
    /// <summary>
    /// Other payment method or reason.
    /// </summary>
    OTHER = 5
}
