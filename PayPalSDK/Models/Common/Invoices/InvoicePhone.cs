using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a phone number associated with invoice entities, including country code,
/// national number, optional extension, and phone type metadata.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoicePhone
{
    /// <summary>
    /// Gets or sets the country code of the phone number in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 3 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("country_code")]
    [StringLength(3)]
    public string? CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the national number of the phone number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("national_number")]
    [StringLength(14)]
    public string? NationalNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the extension number of the phone number.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("extension_number")]
    [StringLength(15)]
    public string? ExtensionNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the type of the phone.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the type of phone (e.g., mobile, home, work).
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("phone_type")]
    public string? PhoneType { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}