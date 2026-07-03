using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Webhooks;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Webhooks.Bodies;

/// <summary>
/// Represents the body of a webhook in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the webhook.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the URL associated with the webhook.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("url")]
    [StringLength(2048)]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the list of event types associated with the webhook.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("event_types")]
    public List<Webhook>? EventTypes { get; set; }

    /// <summary>
    /// Gets or sets the list of links related to the webhook.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}