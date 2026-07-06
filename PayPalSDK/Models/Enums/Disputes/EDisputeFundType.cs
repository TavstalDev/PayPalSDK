using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of fund movement in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeFundType>))]
public enum EDisputeFundType
{
    /// <summary>Debit fund type.</summary>
    DEBIT = 0,
    /// <summary>Credit fund type.</summary>
    CREDIT = 1
}
