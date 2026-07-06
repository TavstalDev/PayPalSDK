using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The reason for a fund movement in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeMovementReason>))]
public enum EDisputeMovementReason
{
    /// <summary>Reversed transaction fee movement.</summary>
    REVERSED_TRANSACTION_FEE = 0,
    /// <summary>Dispute settlement movement.</summary>
    DISPUTE_SETTLEMENT = 1,
    /// <summary>Dispute fee movement.</summary>
    DISPUTE_FEE = 2,
    /// <summary>Chargeback fee movement.</summary>
    CHARGEBACK_FEE = 3
}
