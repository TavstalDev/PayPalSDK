using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Webhooks;

/// <summary>
/// Represents a PayPal webhook event type.
/// </summary>
public class WebhookEventType
{
    /// <summary>
    /// Gets or sets the webhook event name.
    /// </summary>
    /// <remarks>
    /// This is the unique event type identifier used by PayPal to distinguish webhook events.
    /// </remarks>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the webhook event description.
    /// </summary>
    /// <remarks>
    /// This provides a human-readable explanation of what the event represents.
    /// </remarks>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}