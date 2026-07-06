using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Orders;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Shipping;

namespace Tavstal.PayPalSDK.Models.Orders.Bodies;

/// <summary>
/// Represents the request body for adding or updating shipment tracking information to a PayPal order.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class OrderTrackingRequestBody
{
    /// <summary>
    /// Gets or sets the shipment tracking number provided by the carrier.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("tracking_number")]
    [Required]
    public string? TrackingNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping carrier identifier.
    /// </summary>
    /// <remarks>
    /// This field is required.
    /// If the carrier is not available for your country, choose the global version of the carrier.
    /// If your carrier name is not in the list, set carrier to OTHER and set carrier name in <see cref="CarrierNameOther"/>.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("carrier")]
    public ECarrier Carrier { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the carrier if it is not in the standard list of carriers.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("carrier_name_other")]
    public string? CarrierNameOther { get; set; }
    
    /// <summary>
    /// Gets or sets the ID of the capture transaction for which tracking information is being provided.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("capture_id")]
    public string? CaptureId { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether PayPal should notify the payer about the shipment tracking update.
    /// </summary>
    /// <remarks>
    /// When set to <c>true</c>, PayPal will send a notification to the payer with the shipment tracking details.
    /// Defaults to <c>false</c>.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("notify_payer")]
    public bool NotifyPayer { get; set; }
    
    /// <summary>
    /// Gets or sets the list of items included in this shipment.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<TrackingItem>? Items { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}