using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The source of a payment constraint.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentConstraintSource>))]
public enum EPaymentConstraintSource
{
    /// <summary>
    /// PayPal payment method.
    /// </summary>
    PAYPAL = 0,
    /// <summary>
    /// Venmo payment method.
    /// </summary>
    VENMO = 1,
    /// <summary>
    /// PayPal Credit payment method.
    /// </summary>
    PAYPAL_CREDIT = 2,
    /// <summary>
    /// PayPal Pay Later payment method.
    /// </summary>
    PAYPAL_PAY_LATER = 3,
    /// <summary>
    /// ACH payment method.
    /// </summary>
    ACH = 4
}
