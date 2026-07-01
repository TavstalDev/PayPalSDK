using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Orders;

namespace Tavstal.PayPalSDK.Models.Orders.Bodies;

/// <summary>
/// Represents the request body for adding or updating shipment tracking information to a PayPal order.
/// </summary>
public class OrderTrackingRequestBody
{
    /// <summary>
    /// Gets or sets the shipment tracking number provided by the carrier.
    /// </summary>
    [JsonPropertyName("tracking_number")]
    public required string TrackingNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping carrier identifier.
    /// </summary>
    /// <remarks>
    /// This field is required and should be set to a value from the <see cref="Tavstal.PayPalSDK.Constants.Carriers"/> constants.
    /// If the carrier is not available for your country, choose the global version of the carrier.
    /// If your carrier name is not in the list, set carrier to OTHER and set carrier name in <see cref="CarrierNameOther"/>.
    /// </remarks>
    [JsonPropertyName("carrier")]
    public required string Carrier { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the carrier if it is not in the standard list of carriers.
    /// </summary>
    [JsonPropertyName("carrier_name_other")]
    public string? CarrierNameOther { get; set; }
    
    /// <summary>
    /// Gets or sets the ID of the capture transaction for which tracking information is being provided.
    /// </summary>
    [JsonPropertyName("capture_id")]
    public required string CaptureId { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether PayPal should notify the payer about the shipment tracking update.
    /// </summary>
    /// <remarks>
    /// When set to <c>true</c>, PayPal will send a notification to the payer with the shipment tracking details.
    /// Defaults to <c>false</c>.
    /// </remarks>
    [JsonPropertyName("notify_payer")]
    public bool NotifyPayer { get; set; }
    
    /// <summary>
    /// Gets or sets the list of items included in this shipment.
    /// </summary>
    [JsonPropertyName("items")]
    public List<TrackingItem>? Items { get; set; }
}