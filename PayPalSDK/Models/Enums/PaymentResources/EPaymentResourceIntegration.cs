using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.PaymentResources;

/// <summary>
/// The integration type of payment resource.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentResourceIntegration>))]
public enum EPaymentResourceIntegration
{
    /// <summary>Link-based integration.</summary>
    LINK = 0
}
