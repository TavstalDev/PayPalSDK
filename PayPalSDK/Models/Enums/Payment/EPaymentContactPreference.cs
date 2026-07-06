using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The contact information preference for payment processing.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentContactPreference>))]
public enum EPaymentContactPreference
{
    /// <summary>No contact information is used.</summary>
    NO_CONTACT_INFO = 0,
    /// <summary>Contact information will be updated.</summary>
    UPDATE_CONTACT_INFO = 1,
    /// <summary>Existing contact information will be retained.</summary>
    RETAIN_CONTACT_INFO = 2
}
