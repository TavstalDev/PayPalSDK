using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Webhooks;

/// <summary>
/// Represents a PayPal webhook event type.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookEventType
{
    /// <summary>
    /// Gets or sets the webhook event name.
    /// </summary>
    /// <remarks>
    /// This is the unique event type identifier used by PayPal to distinguish webhook events.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the webhook event description.
    /// </summary>
    /// <remarks>
    /// This provides a human-readable explanation of what the event represents.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}