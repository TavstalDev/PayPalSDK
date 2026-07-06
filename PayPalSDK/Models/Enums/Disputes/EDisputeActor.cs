using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The actor type in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeActor>))]
public enum EDisputeActor
{
    /// <summary>The buyer party.</summary>
    BUYER = 0,
    /// <summary>The seller party.</summary>
    SELLER = 1
}
