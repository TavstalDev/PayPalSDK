using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The seller protection eligibility status.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ESellerProtectionStatus>))]
public enum ESellerProtectionStatus
{
    /// <summary>The seller is eligible for protection.</summary>
    ELIGIBLE = 0,
    /// <summary>The seller is partially eligible for protection.</summary>
    PARTIALLY_ELIGIBLE = 1,
    /// <summary>The seller is not eligible for protection.</summary>
    NOT_ELIGIBLE = 2
}
