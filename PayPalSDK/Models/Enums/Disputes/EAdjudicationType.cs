using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of adjudication action.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EAdjudicationType>))]
public enum EAdjudicationType
{
    /// <summary>Deny the buyer's claim.</summary>
    DENY_BUYER = 0,
    /// <summary>Payout to the buyer.</summary>
    PAYOUT_TO_BUYER = 1,
    /// <summary>Payout to the seller.</summary>
    PAYOUT_TO_SELLER = 2,
    /// <summary>Recover funds from the seller.</summary>
    RECOVER_FROM_SELLER = 3
}
