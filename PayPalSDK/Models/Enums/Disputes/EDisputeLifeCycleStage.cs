using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The lifecycle stage of a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeLifeCycleStage>))]
public enum EDisputeLifeCycleStage
{
    /// <summary>Dispute is in the inquiry stage.</summary>
    INQUIRY = 0,
    /// <summary>Dispute is in the chargeback stage.</summary>
    CHARGEBACK = 1,
    /// <summary>Dispute is in the pre-arbitration stage.</summary>
    PRE_ARBITRATION = 2,
    /// <summary>Dispute is in the arbitration stage.</summary>
    ARBITRATION = 3
}
