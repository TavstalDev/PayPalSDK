using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The Google Pay payment method type.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EGooglePaymentMethod>))]
public enum EGooglePaymentMethod
{
    /// <summary>Card payment method.</summary>
    CARD = 0
}
