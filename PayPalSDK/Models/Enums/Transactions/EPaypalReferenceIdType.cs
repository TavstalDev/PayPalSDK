using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Transactions;

/// <summary>
/// The type of PayPal reference identifier.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaypalReferenceIdType>))]
public enum EPaypalReferenceIdType
{
    /// <summary>Reference is an order ID.</summary>
    ODR = 0,
    /// <summary>Reference is a transaction ID.</summary>
    TXN = 1,
    /// <summary>Reference is a subscription ID.</summary>
    SUB = 2,
    /// <summary>Reference is a pre-approved payment ID.</summary>
    PAP = 3
}
