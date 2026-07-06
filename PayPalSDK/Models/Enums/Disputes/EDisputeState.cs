using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The current state of a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeState>))]
public enum EDisputeState
{
    /// <summary>
    /// Open inquiries state.
    /// </summary>
    OPEN_INQUIRIES = 0,
    /// <summary>
    /// Action is required from one party.
    /// </summary>
    REQUIRED_ACTION = 1,
    /// <summary>
    /// Action is required from the other party.
    /// </summary>
    REQUIRED_OTHER_PARTY_ACTION = 2,
    /// <summary>
    /// Under PayPal review.
    /// </summary>
    UNDER_PAYPAL_REVIEW = 3,
    /// <summary>
    /// The dispute decision is appealable.
    /// </summary>
    APPEALABLE = 4,
    /// <summary>
    /// The dispute has been resolved.
    /// </summary>
    RESOLVED = 5
}
