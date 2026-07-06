using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The type of payment.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentType>))]
public enum EPaymentType
{
    /// <summary>One-time payment.</summary>
    ONE_TIME = 0,
    /// <summary>Recurring payment.</summary>
    RECURRING = 1,
    /// <summary>Unscheduled payment.</summary>
    UNSCHEDULED = 2
}
