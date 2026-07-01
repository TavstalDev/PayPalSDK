using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents shipment information related to a PayPal dispute, including the shipment label and tracking information.
/// </summary>
public class ShipmentInfo
{
    /// <summary>
    /// Gets or sets the shipment label associated with the disputed item.
    /// </summary>
    [JsonPropertyName("shipment_label")]
    public required NameObj ShipmentLabel { get; set; }
    
    /// <summary>
    /// Gets or sets the tracking information for the shipment, including carrier and tracking number.
    /// </summary>
    [JsonPropertyName("tracking_info")]
    public required TrackingInfo TrackingInfo { get; set; }
}