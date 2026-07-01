using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents the response body for adding tracking information to a PayPal transaction.
/// </summary>
public class TrackingAddResponseBody
{
    /// <summary>
    /// Gets or sets the list of tracker identifiers associated with the added tracking information.
    /// </summary>
    [JsonPropertyName("tracker_identifiers")]
    public List<TrackerIdentifier>? TrackerIdentifiers { get; set; }
}