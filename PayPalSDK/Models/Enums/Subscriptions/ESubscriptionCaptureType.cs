using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The type of subscription capture.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ESubscriptionCaptureType>))]
public enum ESubscriptionCaptureType
{
    /// <summary>Capture outstanding balance.</summary>
    OUTSTANDING_BALANCE = 0
}
