using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The payment method preference for processing transactions.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentMethodPreference>))]
public enum EPaymentMethodPreference
{
    /// <summary>No restriction on payment method.</summary>
    UNRESTRICTED = 0,
    /// <summary>Immediate payment is required.</summary>
    IMMEDIATE_PAYMENT_REQUIRED = 1
}
