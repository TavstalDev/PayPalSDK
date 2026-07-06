using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The type of phone number.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPhoneType>))]
public enum EPhoneType
{
    /// <summary>
    /// A fax number.
    /// </summary>
    FAX = 0,
    /// <summary>
    /// A home phone number.
    /// </summary>
    HOME = 1,
    /// <summary>
    /// A mobile phone number.
    /// </summary>
    MOBILE = 2,
    /// <summary>
    /// A phone number of another type.
    /// </summary>
    OTHER = 3,
    /// <summary>
    /// A pager number.
    /// </summary>
    PAGER = 4
}
