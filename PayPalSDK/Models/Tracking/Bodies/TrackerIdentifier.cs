using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents a tracker identifier containing transaction and tracking information for a shipment.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TrackerIdentifier
{
    /// <summary>
    /// Gets or sets the transaction identifier associated with this tracker.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transaction_id")]
    public string? TransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets the shipment tracking number provided by the carrier.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("tracking_number")]
    public string? TrackingNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the URL where tracking details can be viewed.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}