using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The Electronic Commerce Indicator (ECI) flag indicating the 3D Secure authentication level of a transaction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EEciFlag>))]
public enum EEciFlag
{
    /// <summary>
    /// Mastercard Non-3D Secure Transaction value.
    /// </summary>
    MASTERCARD_NON_3D_SECURE_TRANSACTION = 0,
    /// <summary>
    /// Mastercard Attempted Authentication Transaction value.
    /// </summary>
    MASTERCARD_ATTEMPTED_AUTHENTICATION_TRANSACTION = 1,
    /// <summary>
    /// Mastercard Fully Authenticated Transaction value.
    /// </summary>
    MASTERCARD_FULLY_AUTHENTICATED_TRANSACTION = 2,
    /// <summary>
    /// Fully Authenticated Transaction value.
    /// </summary>
    FULLY_AUTHENTICATED_TRANSACTION = 3,
    /// <summary>
    /// Attempted Authentication Transaction value.
    /// </summary>
    ATTEMPTED_AUTHENTICATION_TRANSACTION = 4,
    /// <summary>
    /// Non 3D Secure Transaction value.
    /// </summary>
    NON_3D_SECURE_TRANSACTION = 5
}
