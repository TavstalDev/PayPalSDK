using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The channel through which a dispute was created.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeChannel>))]
public enum EDisputeChannel
{
    /// <summary>Dispute created internally.</summary>
    INTERNAL = 0,
    /// <summary>External refund or transaction.</summary>
    EXTERNAL = 1,
    /// <summary>Dispute created via alert.</summary>
    ALERT = 2
}
