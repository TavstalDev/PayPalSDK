using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a BanContact payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class BanContactSource
{
    /// <summary>
    /// Gets or sets the name associated with the BanContact payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name")]
    [StringLength(300)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the country code associated with the BanContact payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a valid two-letter country code or "C2".
    /// </remarks>
    [DataMember(Name = "country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the BanContact payment experience.
    /// </summary>
    public ExperienceContext ExperienceContext { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BanContactSource"/> class.
    /// </summary>
    /// <param name="name">The name associated with the BanContact payment source.</param>
    /// <param name="countryCode">The country code associated with the BanContact payment source.</param>
    /// <param name="experienceContext">The experience context for the payment source.</param>
    public BanContactSource(string name, string countryCode, ExperienceContext experienceContext)
    {
        Name = name;
        CountryCode = countryCode;
        ExperienceContext = experienceContext;
    }
}