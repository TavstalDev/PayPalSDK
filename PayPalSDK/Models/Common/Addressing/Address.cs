using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents an address model used in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Address
{
    /// <summary>
    /// Gets or sets the first line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("address_line_1")]
    [StringLength(300)]
    public string? AddressLineOne { get; set; }

    /// <summary>
    /// Gets or sets the second line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("address_line_2")]
    [StringLength(300)]
    public string? AddressLineTwo { get; set; }

    /// <summary>
    /// Gets or sets the third line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("address_line_3")]
    [StringLength(100)]
    public string? AddressLineThree { get; set; }
    
    /// <summary>
    /// Gets or sets the administrative area (e.g., state or province).
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("admin_area_1")]
    [StringLength(300)]
    public string? AdminAreaOne { get; set; }

    /// <summary>
    /// Gets or sets the locality or city.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 120 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("admin_area_2")]
    [StringLength(120)]
    public string? AdminAreaTwo { get; set; }
    
    /// <summary>
    /// Gets or sets the third administrative area line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("admin_area_3")]
    [StringLength(100)]
    public string? AdminAreaThree { get; set; }

    /// <summary>
    /// Gets or sets the fourth administrative area line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 100 characters.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("admin_area_4")]
    [StringLength(100)]
    public string? AdminAreaFour { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 60 characters.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("postal_code")]
    [StringLength(60)]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 2 characters.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the structured address details.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains more granular address components such as street number,
    /// street name, building name, and sub-building information. It is used to represent detailed
    /// address formatting when a single address line is not sufficient.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("address_details")]
    public AddressDetails? AddressDetails { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(10, "Build")]
    public void Build() { }
}