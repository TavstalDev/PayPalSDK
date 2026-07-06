using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The tenure type for a billing plan.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ETenureType>))]
public enum ETenureType
{
    /// <summary>Regular tenure type.</summary>
    REGULAR = 0,
    /// <summary>Trial tenure type.</summary>
    TRIAL = 1
}
