using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of offer made in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeOffer>))]
public enum EDisputeOffer
{
    /// <summary>Refund offer.</summary>
    REFUND = 0,
    /// <summary>Refund with return of item.</summary>
    REFUND_WITH_RETURN = 1,
    /// <summary>Refund with replacement item.</summary>
    REFUND_WITH_REPLACEMENT = 2,
    /// <summary>Replacement without refund.</summary>
    REPLACEMENT_WITHOUT_REFUND = 3
}
