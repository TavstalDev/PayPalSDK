using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Webhooks;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Webhooks.Bodies;

/// <summary>
/// Represents the body of a request to create a webhook in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookCreateRequestBody
{
    /// <summary>
    /// Gets or sets the URL associated with the webhook.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("url")]
    [StringLength(2048)]
    [Required]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the list of event types associated with the webhook.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("event_types")]
    public List<Webhook>? EventTypes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}