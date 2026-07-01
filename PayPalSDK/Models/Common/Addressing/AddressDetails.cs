using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents detailed address components such as street number, street name, and building information.
/// </summary>
public class AddressDetails
{
    /// <summary>
    /// Gets or sets the street number.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("street_number")]
    [StringLength(100)]
    public string? StreetNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the street name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("street_name")]
    [StringLength(100)]
    public string? StreetName { get; set; }
    
    /// <summary>
    /// Gets or sets the street type.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("street_type")]
    [StringLength(100)]
    public string? StreetType { get; set; }
    
    /// <summary>
    /// Gets or sets the delivery service.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("delivery_service")]
    [StringLength(100)]
    public string? DeliveryService { get; set; }
    
    /// <summary>
    /// Gets or sets the building name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("building_name")]
    [StringLength(100)]
    public string? BuildingName { get; set; }
    
    /// <summary>
    /// Gets or sets the sub-building or unit identifier.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [JsonPropertyName("sub_building")]
    [StringLength(100)]
    public string? SubBuilding { get; set; }
}