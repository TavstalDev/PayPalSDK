using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents a request body for adding shipment tracking information to a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TrackingAddRequestBody
{
    /// <summary>
    /// Gets or sets the list of trackers containing shipment tracking information to be added.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("trackers")]
    public List<Tracker>? Trackers { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}