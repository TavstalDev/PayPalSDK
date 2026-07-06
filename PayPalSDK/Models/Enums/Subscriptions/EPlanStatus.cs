using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The status of a billing plan.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPlanStatus>))]
public enum EPlanStatus
{
    /// <summary>The resource has been created.</summary>
    CREATED = 0,
    /// <summary>The resource is inactive.</summary>
    INACTIVE = 1,
    /// <summary>The subscription is active.</summary>
    ACTIVE = 2
}
