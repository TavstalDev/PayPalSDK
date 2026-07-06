using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The initiator of a payment.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentInitator>))]
public enum EPaymentInitator
{
    /// <summary>Payment initiated by the customer.</summary>
    CUSTOMER = 0,
    /// <summary>Payment initiated by the merchant.</summary>
    MERCHANT = 1
}
