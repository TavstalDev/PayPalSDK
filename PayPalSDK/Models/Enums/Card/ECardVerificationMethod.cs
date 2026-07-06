using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Card;

/// <summary>
/// The card verification method for payment processing.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<ECardVerificationMethod>))]
public enum ECardVerificationMethod
{
    /// <summary>Strong Customer Authentication always required.</summary>
    SCA_ALWAYS = 0,
    /// <summary>Strong Customer Authentication when required.</summary>
    SCA_WHEN_REQUIRED = 1,
    /// <summary>3D Secure verification.</summary>
    [JsonPropertyName("3D_SECURE")]
    THREED_SECURE = 2,
    /// <summary>Address Verification and Card Verification Value.</summary>
    AVS_CVV = 3
}
