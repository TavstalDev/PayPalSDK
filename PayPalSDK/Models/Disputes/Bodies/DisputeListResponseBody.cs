using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the response body for a list of PayPal disputes.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DisputeListResponseBody
{
    /// <summary>
    /// Gets or sets the list of disputes returned in the response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<Dispute>? Items { get; set; }
    
    /// <summary>
    /// Gets or sets the pagination links for navigating through the list of disputes.
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