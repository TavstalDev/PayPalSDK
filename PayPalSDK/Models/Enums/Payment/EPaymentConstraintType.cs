using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Payment;

/// <summary>
/// The type of payment constraint.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentConstraintType>))]
public enum EPaymentConstraintType
{
    /// <summary>Include the specified items.</summary>
    INCLUDE = 0,
    /// <summary>Exclude the specified items.</summary>
    EXCLUDE = 1
}
