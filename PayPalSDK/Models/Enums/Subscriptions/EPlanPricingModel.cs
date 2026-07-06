using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The pricing model for a plan.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPlanPricingModel>))]
public enum EPlanPricingModel
{
    /// <summary>Volume-based pricing.</summary>
    VOLUME = 0,
    /// <summary>Tiered pricing.</summary>
    TIERED = 1
}
