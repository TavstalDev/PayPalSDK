using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Webhooks;

/// <summary>
/// Represents a webhook event in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Webhook
{
    /// <summary>
    /// Gets or sets the unique identifier of the webhook.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the webhook event.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the webhook event.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// Gets or sets the callback URL associated with the webhook.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    
    /// <summary>
    /// Gets or sets the status of the webhook event.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the list of resource versions associated with the webhook event.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("resource_versions")]
    public List<string>? ResourceVersions { get; set; }

    /// <summary>
    /// Gets or sets the list of webhook event types subscribed to by this webhook.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("event_types")]
    public List<WebhookEventType>? EventTypes { get; set; }
    
    /// <summary>
    /// Gets or sets the hypermedia links associated with the webhook.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}