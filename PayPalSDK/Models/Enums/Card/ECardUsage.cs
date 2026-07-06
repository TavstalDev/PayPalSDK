using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Card;

/// <summary>
/// The usage type of card.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECardUsage>))]
public enum ECardUsage
{
    /// <summary>First usage of the card.</summary>
    FIRST = 0,
    /// <summary>Subsequent usage of the card.</summary>
    SUBSEQUENT = 1,
    /// <summary>Derived usage type.</summary>
    DERIVED = 2
}
