using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The return mode for disputed items.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeReturnMode>))]
public enum EDisputeReturnMode
{
    /// <summary>Return shipped back.</summary>
    SHIPPED = 0,
    /// <summary>Cancellation or contact in person.</summary>
    IN_PERSON = 1
}
