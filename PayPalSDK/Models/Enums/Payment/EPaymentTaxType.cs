using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The type of tax calculation for payment items.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentTaxType>))]
public enum EPaymentTaxType
{
    /// <summary>Tax calculated as a percentage.</summary>
    PERCENTAGE = 0,
    /// <summary>Combined tax setting.</summary>
    PREFERENCE = 1
}
