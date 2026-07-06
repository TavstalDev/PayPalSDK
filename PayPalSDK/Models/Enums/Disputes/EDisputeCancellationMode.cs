using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The method used to cancel a disputed transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeCancellationMode>))]
public enum EDisputeCancellationMode
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
