using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents shipment information related to a PayPal dispute, including the shipment label and tracking information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ShipmentInfo
{
    /// <summary>
    /// Gets or sets the shipment label associated with the disputed item.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("shipment_label")]
    [Required]
    public NameObj? ShipmentLabel { get; set; }
    
    /// <summary>
    /// Gets or sets the tracking information for the shipment, including carrier and tracking number.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("tracking_info")]
    public TrackingInfo? TrackingInfo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}