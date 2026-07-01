using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the response returned by the subscription list endpoint of the PayPal Billing API.
/// </summary>
public class SubscriptionListResponse
{
    /// <summary>
    /// Gets or sets the list of subscription objects returned in this response.
    /// </summary>
    [JsonPropertyName("subscriptions")]
    public List<SubscriptionBody>? Subscriptions { get; set; }
    
    /// <summary>
    /// Gets or sets the hypermedia links associated with this subscription list response.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}