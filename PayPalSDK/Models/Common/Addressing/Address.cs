using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents an address model used in the PayPal SDK.
/// </summary>
[DataContract]
public class Address
{
    /// <summary>
    /// Gets or sets the first line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "address_line_1", EmitDefaultValue = false)]
    [StringLength(300)]
    public string AddressLineOne { get; set; }

    /// <summary>
    /// Gets or sets the second line of the address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "address_line_2", EmitDefaultValue = false)]
    [StringLength(300)]
    public string AddressLineTwo { get; set; }

    /// <summary>
    /// Gets or sets the administrative area (e.g., state or province).
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "admin_area_1", EmitDefaultValue = false)]
    [StringLength(300)]
    public string AdminAreaOne { get; set; }

    /// <summary>
    /// Gets or sets the locality or city.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 120 characters.
    /// </remarks>
    [DataMember(Name = "admin_area_2", EmitDefaultValue = false)]
    [StringLength(120)]
    public string AdminAreaTwo { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 60 characters.
    /// </remarks>
    [DataMember(Name = "postal_code", EmitDefaultValue = false)]
    [StringLength(60)]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 2 characters.
    /// </remarks>
    [DataMember(Name = "country_code", EmitDefaultValue = false)]
    [StringLength(2)]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Address"/> class.
    /// </summary>
    /// <param name="addressLineOne">The first line of the address.</param>
    /// <param name="addressLineTwo">The second line of the address.</param>
    /// <param name="adminAreaOne">The administrative area (e.g., state or province).</param>
    /// <param name="adminAreaTwo">The locality or city.</param>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="countryCode">The country code in ISO 3166-1 alpha-2 format.</param>
    public Address(string addressLineOne, string addressLineTwo, string adminAreaOne, string adminAreaTwo,
        string postalCode, string countryCode)
    {
        AddressLineOne = addressLineOne;
        AddressLineTwo = addressLineTwo;
        AdminAreaOne = adminAreaOne;
        AdminAreaTwo = adminAreaTwo;
        PostalCode = postalCode;
        CountryCode = countryCode;
    }
}