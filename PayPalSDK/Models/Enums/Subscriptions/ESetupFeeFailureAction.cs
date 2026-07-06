using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The action to take when a setup fee payment fails.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ESetupFeeFailureAction>))]
public enum ESetupFeeFailureAction
{
    /// <summary>Continue with the current action.</summary>
    CONTINUE = 0,
    /// <summary>Cancel value.</summary>
    CANCEL = 1
}
