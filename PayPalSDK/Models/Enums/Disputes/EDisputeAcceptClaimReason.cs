using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The reason for accepting a dispute claim.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeAcceptClaimReason>))]
public enum EDisputeAcceptClaimReason
{
    /// <summary>
    /// The seller did not ship the item.
    /// </summary>
    DID_NOT_SHIP_ITEM = 0,
    /// <summary>
    /// The process is too time-consuming.
    /// </summary>
    TOO_TIME_CONSUMING = 1,
    /// <summary>
    /// The item was lost in the mail.
    /// </summary>
    LOST_IN_MAIL = 2,
    /// <summary>
    /// The seller is not able to win the dispute.
    /// </summary>
    NOT_ABLE_TO_WIN = 3,
    /// <summary>
    /// Accepting per company policy.
    /// </summary>
    COMPANY_POLICY = 4,
    /// <summary>
    /// Reason has not been set.
    /// </summary>
    REASON_NOT_SET = 5
}
