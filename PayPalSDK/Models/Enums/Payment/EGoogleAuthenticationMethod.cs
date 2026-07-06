using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The Google Pay authentication method for card payments.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EGoogleAuthenticationMethod>))]
public enum EGoogleAuthenticationMethod
{
    /// <summary>Card-on-file authentication.</summary>
    PAN_ONLY = 0,
    /// <summary>3D Secure cryptogram authentication.</summary>
    CRYPTOGRAM_3DS = 1
}
