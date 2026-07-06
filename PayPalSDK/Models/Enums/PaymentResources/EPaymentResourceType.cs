using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.PaymentResources;

/// <summary>
/// The type of payment resource.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentResourceType>))]
public enum EPaymentResourceType
{
    /// <summary>Buy Now payment resource.</summary>
    BUY_NOW = 0
}
