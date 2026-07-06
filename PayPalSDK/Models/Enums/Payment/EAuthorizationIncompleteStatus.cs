using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The reason for an incomplete authorization.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EAuthorizationIncompleteStatus>))]
public enum EAuthorizationIncompleteStatus
{
    /// <summary>The authorization is pending manual review.</summary>
    PENDING_REVIEW = 0,
    /// <summary>Declined by risk or fraud filters.</summary>
    DECLINED_BY_RISK_FRAUD_FILTERS = 1
}
