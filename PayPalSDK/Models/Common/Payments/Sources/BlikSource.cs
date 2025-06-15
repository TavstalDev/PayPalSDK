using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a Blik payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class BlikSource
{
    /// <summary>
    /// Gets or sets the name associated with the Blik payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name")]
    [StringLength(300)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the country code associated with the Blik payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a valid two-letter country code or "C2".
    /// </remarks>
    [DataMember(Name = "country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the Blik payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and must be a valid email address with a maximum length of 254 characters.
    /// </remarks>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    [StringLength(254)]
    [RegularExpression("^(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])$")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the Blik payment experience.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional configuration for the payment experience.
    /// </remarks>
    [DataMember(Name = "experience_context", EmitDefaultValue = false)]
    public ExperienceContext ExperienceContext { get; set; }

    /// <summary>
    /// Gets or sets the Level Zero payment source details.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents Level Zero payment source information.
    /// </remarks>
    [DataMember(Name = "level_0", EmitDefaultValue = false)]
    public LevelZero LevelZero { get; set; }

    /// <summary>
    /// Gets or sets the OneClick payment source details.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents OneClick payment source information.
    /// </remarks>
    [DataMember(Name = "one_click", EmitDefaultValue = false)]
    public OneClick OneClick { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BlikSource"/> class.
    /// </summary>
    /// <param name="name">The name associated with the Blik payment source.</param>
    /// <param name="countryCode">The country code associated with the Blik payment source.</param>
    /// <param name="email">The email address associated with the Blik payment source.</param>
    /// <param name="experienceContext">The experience context for the payment source.</param>
    /// <param name="levelZero">The Level Zero payment source details.</param>
    /// <param name="oneClick">The OneClick payment source details.</param>
    public BlikSource(string name, string countryCode, string email, ExperienceContext experienceContext, LevelZero levelZero, OneClick oneClick)
    {
        Name = name;
        CountryCode = countryCode;
        Email = email;
        ExperienceContext = experienceContext;
        LevelZero = levelZero;
        OneClick = oneClick;
    }
}