using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents detailed address components such as street number, street name, and building information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class AddressDetails
{
    /// <summary>
    /// Gets or sets the street number.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("street_number")]
    [StringLength(100)]
    public string? StreetNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the street name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("street_name")]
    [StringLength(100)]
    public string? StreetName { get; set; }
    
    /// <summary>
    /// Gets or sets the street type.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("street_type")]
    [StringLength(100)]
    public string? StreetType { get; set; }
    
    /// <summary>
    /// Gets or sets the delivery service.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("delivery_service")]
    [StringLength(100)]
    public string? DeliveryService { get; set; }
    
    /// <summary>
    /// Gets or sets the building name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("building_name")]
    [StringLength(100)]
    public string? BuildingName { get; set; }
    
    /// <summary>
    /// Gets or sets the sub-building or unit identifier.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("sub_building")]
    [StringLength(100)]
    public string? SubBuilding { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}