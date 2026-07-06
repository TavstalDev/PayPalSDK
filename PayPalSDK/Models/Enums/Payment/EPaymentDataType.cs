using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The type of payment data used in transaction processing.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EPaymentDataType>))]
public enum EPaymentDataType
{
    /// <summary>3D Secure payment data.</summary>
    [JsonPropertyName("3DSECURE")]
    THREEDSECURE = 0,
    /// <summary>EMV payment data.</summary>
    EMV = 1
}
