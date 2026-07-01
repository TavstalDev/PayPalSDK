using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents a request body for adding shipment tracking information to a PayPal transaction.
/// </summary>
public class TrackingAddRequestBody
{
    /// <summary>
    /// Gets or sets the list of trackers containing shipment tracking information to be added.
    /// </summary>
    [JsonPropertyName("trackers")]
    public List<Tracker>? Trackers { get; set; }
}