using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The type of refund.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ERefundType>))]
public enum ERefundType
{
    /// <summary>PayPal payment method.</summary>
    PAYPAL = 0,
    /// <summary>External refund or transaction.</summary>
    EXTERNAL = 1
}
