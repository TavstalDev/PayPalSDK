using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of event in a dispute workflow.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeEventType>))]
public enum EDisputeEventType
{
    /// <summary>An offer has been proposed.</summary>
    PROPOSED = 0,
    /// <summary>The offer was accepted.</summary>
    ACCEPTED = 1,
    /// <summary>The operation was denied.</summary>
    DENIED = 2
}
