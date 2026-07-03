using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Webhooks;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Webhooks.Bodies;

/// <summary>
/// Represents the response body for a request to list webhooks in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class WebhookListResponseBody
{
    /// <summary>
    /// Gets or sets the list of webhooks returned in the response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("webhooks")]
    public List<Webhook>? Webhooks { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}