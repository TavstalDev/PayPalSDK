using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The outcome of an adjudication.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EAdjudicationOutcome>))]
public enum EAdjudicationOutcome
{
    /// <summary>Decision in favor of the buyer.</summary>
    BUYER_FAVOR = 0,
    /// <summary>Decision in favor of the seller.</summary>
    SELLER_FAVOR = 1
}
