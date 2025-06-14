using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents a phone number with a country code and national number.
/// </summary>
[DataContract]
public class PhoneNumber
{
    /// <summary>
    /// Gets or sets the country code of the phone number in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 3 characters.
    /// </remarks>
    [DataMember(Name = "country_code", EmitDefaultValue = false)]
    [StringLength(3)]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the national number of the phone number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [DataMember(Name = "national_number", EmitDefaultValue = false)]
    [StringLength(14)]
    public required string NationalNumber { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumber"/> class.
    /// </summary>
    /// <param name="countryCode">The country code of the phone number.</param>
    /// <param name="nationalNumber">The national number of the phone number.</param>
    public PhoneNumber(string countryCode, string nationalNumber)
    {
        CountryCode = countryCode;
        NationalNumber = nationalNumber;
    }
}