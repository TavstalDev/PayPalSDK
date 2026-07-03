using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a response body containing a list of links related to a PayPal resource.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class LinksResponseBody
{
    /// <summary>
    /// Gets or sets the list of links related to the PayPal resource.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}