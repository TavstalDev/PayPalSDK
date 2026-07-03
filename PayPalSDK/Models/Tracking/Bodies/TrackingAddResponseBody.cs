using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents the response body for adding tracking information to a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TrackingAddResponseBody
{
    /// <summary>
    /// Gets or sets the list of tracker identifiers associated with the added tracking information.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("tracker_identifiers")]
    public List<TrackerIdentifier>? TrackerIdentifiers { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}