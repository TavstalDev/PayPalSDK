using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Webhooks;

/// <summary>
/// Represents the body of a webhook event in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookEventBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the webhook event.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the webhook event.
    /// </summary>
    /// <remarks>
    /// The creation time is in ISO 8601 format.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the type of the webhook event.
    /// </summary>
    /// <remarks>
    /// The event type indicates the nature of the event, such as payment or refund.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }

    /// <summary>
    /// Gets or sets the version of the webhook event.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("event_version")]
    public string? EventVersion { get; set; }

    /// <summary>
    /// Gets or sets a summary of the webhook event.
    /// </summary>
    /// <remarks>
    /// The summary provides a brief description of the event.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// Gets or sets the version of the resource associated with the webhook event.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("resource_version")]
    public string? ResourceVersion { get; set; }

    /// <summary>
    /// Gets or sets the resource associated with the webhook event.
    /// </summary>
    /// <remarks>
    /// The resource contains the payload of the event.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("resource")]
    public object? Resource { get; set; }

    /// <summary>
    /// Gets or sets the list of links related to the webhook event.
    /// </summary>
    /// <remarks>
    /// The links provide additional information or actions related to the event.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets the creation time of the webhook event as a nullable DateTime object.
    /// </summary>
    public DateTime? CreateTimeAsDateTime => DateTimeHelper.FromISO8601(CreateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}