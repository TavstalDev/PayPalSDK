using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The pricing model for a product or plan.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPricingModel>))]
public enum EPricingModel
{
    /// <summary>The merchant fixed the issue.</summary>
    FIXED = 0,
    /// <summary>Variable pricing model.</summary>
    VARIABLE = 1,
    /// <summary>Auto-reload pricing model.</summary>
    AUTO_RELOAD = 2
}
