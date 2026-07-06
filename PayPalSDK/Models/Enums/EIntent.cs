using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The intent of a payment.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EIntent>))]
public enum EIntent
{
    /// <summary>The payment intent is to capture funds.</summary>
    CAPTURE = 0,
    /// <summary>The payment intent is to authorize funds.</summary>
    AUTHORIZE = 1
}
