using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan.Bodies;

/// <summary>
/// Represents the body of a response containing a list of subscription plans.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionPlanListBody
{
    /// <summary>
    /// Gets or sets the list of subscription plans.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("plans")]
    public List<SubscriptionPlanBody>? Plans { get; set; }

    /// <summary>
    /// Gets or sets the total number of items in the response.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the total number of pages in the response.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the list of links associated with the response.
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