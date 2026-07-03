using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the response returned by the subscription list endpoint of the PayPal Billing API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionListResponse
{
    /// <summary>
    /// Gets or sets the list of subscription objects returned in this response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("subscriptions")]
    public List<SubscriptionBody>? Subscriptions { get; set; }
    
    /// <summary>
    /// Gets or sets the hypermedia links associated with this subscription list response.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}