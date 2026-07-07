using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Shipping;
using Tavstal.PayPalSDK.Models.Enums.Shipping.Tracking;

namespace Tavstal.PayPalSDK.Models.Tracking.Bodies;

/// <summary>
/// Represents shipment tracking information associated with a PayPal transaction,
/// including carrier details, tracking identifiers, shipment metadata, and status.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Tracker
{
    /// <summary>
    /// Gets or sets the transaction identifier associated with this tracker.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("transaction_id")]
    [StringLength(50)]
    public string? TransactionId { get; set; }
   
    /// <summary>
    /// Gets or sets the shipment tracking number provided by the carrier.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("tracking_number")]
    [StringLength(64)]
    public string? TrackingNumber { get; set; }
    
    /// <summary>
    /// Gets or sets a custom carrier name when the carrier is not covered by predefined values.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("carrier_name_other")]
    [StringLength(64)]
    public string? CarrierNameOther { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the buyer should be notified about tracking updates.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("notify_buyer")]
    public bool NotifyBuyer { get; set; }
    
    /// <summary>
    /// Gets or sets the shipment direction.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("shipment_direction")]
    public EShippingDirection? ShipmentDirection { get; set; }
    
    /// <summary>
    /// Gets or sets the URL where tracking details can be viewed.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("tracking_url")]
    [StringLength(250)]
    [RegularExpression("^.*$")]
    public string? TrackingUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the fulfillment provider handling the shipment.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("fulfillment_provider")]
    [StringLength(64)]
    public string? FulfillmentProvider { get; set; }
    
    /// <summary>
    /// Gets or sets the tracking number type.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("tracking_number_type")]
    public ETrackingNumberType? TrackingNumberType { get; set; }
    
    /// <summary>
    /// Gets or sets the current tracking status.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public ETrackingStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the shipment date in <c>yyyy-MM-dd</c> format.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("shipment_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? ShipmentDate { get; set; }
    
    /// <summary>
    /// Gets or sets the carrier identifier or name.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("carrier")]
    public ECarrier? Carrier { get; set; }
    
    /// <summary>
    /// Gets or sets the last tracking update time as an ISO 8601 string.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("last_update_time")]
    [StringLength(maximumLength:64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? LastUpdateTime { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="LastUpdateTime"/>, if valid.
    /// </summary>
    public DateTime? LastUpdateTimeAsDateTime => DateTimeHelper.FromISO8601(LastUpdateTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(12, "Build")]
    public void Build() { }
}