using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The payment method used in a dispute transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputePaymentMethod>))]
public enum EDisputePaymentMethod
{
    /// <summary>
    /// Cash payment method.
    /// </summary>
    CASH = 0,
    /// <summary>
    /// Credit card payment method.
    /// </summary>
    CREDIT_CARD = 1,
    /// <summary>
    /// Check payment method.
    /// </summary>
    CHECK = 2,
    /// <summary>
    /// PayPal payment method.
    /// </summary>
    PAYPAL = 3,
    /// <summary>
    /// Debit card payment method.
    /// </summary>
    DEBIT_CARD = 4,
    /// <summary>
    /// Gift card payment method.
    /// </summary>
    GIFT_CARD = 5,
    /// <summary>
    /// Bank transfer payment method.
    /// </summary>
    BANK_TRANSFER = 6
}
