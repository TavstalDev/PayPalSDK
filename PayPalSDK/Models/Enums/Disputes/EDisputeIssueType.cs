using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The type of issue in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeIssueType>))]
public enum EDisputeIssueType
{
    /// <summary>Product-related issue.</summary>
    PRODUCT = 0,
    /// <summary>Service-related issue.</summary>
    SERVICE = 1
}
