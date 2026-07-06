using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The outcome of merchant actions in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeMerchantOutcome>))]
public enum EDisputeMerchantOutcome
{
    /// <summary>The merchant did not respond.</summary>
    NO_RESPONSE = 0,
    /// <summary>The merchant fixed the issue.</summary>
    FIXED = 1,
    /// <summary>The merchant responded.</summary>
    RESPONDED = 2,
    /// <summary>The merchant did not fix the issue.</summary>
    NOT_FIXED = 3
}
