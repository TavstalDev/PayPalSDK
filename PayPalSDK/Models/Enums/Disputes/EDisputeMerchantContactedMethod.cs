using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The method used by the merchant to contact the buyer.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeMerchantContactedMethod>))]
public enum EDisputeMerchantContactedMethod
{
    /// <summary>
    /// Cancellation or contact via website.
    /// </summary>
    WEBSITE = 0,
    /// <summary>
    /// Cancellation or contact via phone.
    /// </summary>
    PHONE = 1,
    /// <summary>
    /// Cancellation or contact via email.
    /// </summary>
    EMAIL = 2,
    /// <summary>
    /// Cancellation or contact via written communication.
    /// </summary>
    WRITTEN = 3,
    /// <summary>
    /// Cancellation or contact in person.
    /// </summary>
    IN_PERSON = 4
}
