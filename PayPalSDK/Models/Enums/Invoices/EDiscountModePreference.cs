using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The discount mode preference for invoices.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDiscountModePreference>))]
public enum EDiscountModePreference
{
    /// <summary>One-time payment.</summary>
    ONE_TIME = 0,
    /// <summary>Save discount for future use.</summary>
    SAVE_FOR_FUTURE = 1
}
