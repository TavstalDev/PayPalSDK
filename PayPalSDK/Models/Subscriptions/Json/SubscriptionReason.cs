using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Json;

/// <summary>
/// Represents a payload containing a human-readable reason associated with a subscription action
/// (for example, suspend or cancel operations in the PayPal Subscriptions API).
/// </summary>
public class SubscriptionReason
{
    /// <summary>
    /// Gets or sets the reason text sent to the API.
    /// </summary>
    [JsonPropertyName("reason")]
    [StringLength(128)]
    public required string Reason { get; set; }
}