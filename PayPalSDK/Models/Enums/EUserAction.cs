using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The user action type during checkout.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EUserAction>))]
public enum EUserAction
{
    /// <summary>Continue with the current action.</summary>
    CONTINUE = 0,
    /// <summary>Proceed to payment immediately.</summary>
    PAY_NOW = 1
}
