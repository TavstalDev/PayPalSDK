using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents an item in a shipment tracking update sent to the PayPal API.
/// </summary>
public class TrackingItem
{
    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [JsonPropertyName("name")]
    [StringLength(127)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 10 characters.
    /// </remarks>
    [JsonPropertyName("quantity")]
    [StringLength(10)]
    public required string Quantity { get; set; }

    /// <summary>
    /// Gets or sets the stock keeping unit (SKU) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [JsonPropertyName("sku")]
    [StringLength(127)]
    public string? Sku { get; set; }

    /// <summary>
    /// Gets or sets the URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [JsonPropertyName("url")]
    [StringLength(2048)]
    public string? Url { get; set; }
    
    /// <summary>
    /// Gets or sets the image URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [JsonPropertyName("image_url")]
    [StringLength(2048)]
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the Universal Product Code (UPC) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the UPC details.
    /// </remarks>
    [JsonPropertyName("upc")]
    public UPC? UPC { get; set; }
}