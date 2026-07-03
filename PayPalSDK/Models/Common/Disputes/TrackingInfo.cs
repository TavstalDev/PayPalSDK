using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents tracking information for a shipment in a PayPal dispute.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TrackingInfo
{
    /// <summary>
    /// Gets or sets the name of the carrier responsible for shipping the item.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("carrier_name")]
    [StringLength(255)]
    [Required]
    public string? CarrierName { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the carrier if it is not listed in the predefined options.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("carrier_name_other")]
    [StringLength(2000)]
    public string? CarrierNameOther { get; set; }
    
    /// <summary>
    /// Gets or sets the URL for tracking the shipment. This property is optional and can be null if no tracking URL is available.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("tracking_url")]
    public string? TrackingUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the tracking number associated with the shipment. This property is required and has a maximum length of 255 characters.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("tracking_number")]
    [StringLength(255)]
    public string? TrackingNumber { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}