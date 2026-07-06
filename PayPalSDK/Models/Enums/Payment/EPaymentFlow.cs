using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The flow type of payment transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentFlow>))]
public enum EPaymentFlow
{
    /// <summary>One-time payment flow.</summary>
    ONE_TIME_PAYMENT = 0,
    /// <summary>Recurring payment flow.</summary>
    RECURRING_PAYMENT = 1,
    /// <summary>Vault payment method with a payment.</summary>
    VAULT_WITH_PAYMENT = 2,
    /// <summary>Vault payment method without a payment.</summary>
    VAULT_WITHOUT_PAYMENT = 3
}
