using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The type of landing page to display on the PayPal checkout page.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentLandingPageType>))]
public enum EPaymentLandingPageType
{
    /// <summary>Login landing page.</summary>
    LOGIN = 0,
    /// <summary>Guest checkout landing page.</summary>
    GUEST_CHECKOUT = 1,
    /// <summary>No preference landing page.</summary>
    NO_PREFERENCE = 2,
    /// <summary>Billing landing page.</summary>
    BILLING = 3
}
