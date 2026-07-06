using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The party involved in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeParty>))]
public enum EDisputeParty
{
    /// <summary>The seller party.</summary>
    SELLER = 0,
    /// <summary>The buyer party.</summary>
    BUYER = 1
}
