using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Card;

/// <summary>
/// The type of payment card.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECardType>))]
public enum ECardType
{
    /// <summary>
    /// Credit fund type.
    /// </summary>
    CREDIT = 0,
    /// <summary>
    /// Debit fund type.
    /// </summary>
    DEBIT = 1,
    /// <summary>
    /// Prepaid card type.
    /// </summary>
    PREPAID = 2,
    /// <summary>
    /// Store card type.
    /// </summary>
    STORE = 3,
    /// <summary>
    /// Unknown card type.
    /// </summary>
    UNKNOWN = 4
}
