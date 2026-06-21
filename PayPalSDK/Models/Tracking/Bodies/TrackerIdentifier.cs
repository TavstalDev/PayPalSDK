using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents a tracker identifier containing transaction and tracking information for a shipment.
/// </summary>
public class TrackerIdentifier
{
    /// <summary>
    /// Gets or sets the transaction identifier associated with this tracker.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public string? TransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets the shipment tracking number provided by the carrier.
    /// </summary>
    [JsonPropertyName("tracking_number")]
    public string? TrackingNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the URL where tracking details can be viewed.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}