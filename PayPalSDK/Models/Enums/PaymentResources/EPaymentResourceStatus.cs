using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.PaymentResources;

/// <summary>
/// The status of a payment resource.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentResourceStatus>))]
public enum EPaymentResourceStatus
{
    /// <summary>The subscription is active.</summary>
    ACTIVE = 0,
    /// <summary>The resource is inactive.</summary>
    INACTIVE = 1
}
