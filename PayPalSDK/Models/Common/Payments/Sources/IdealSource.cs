using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents an iDEAL payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class IdealSource
{
    /// <summary>
    /// Gets or sets the name associated with the iDEAL payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 300 characters.
    /// </remarks>
    [JsonPropertyName("name")]
    [StringLength(300)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the country code associated with the iDEAL payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a valid two-letter country code or "C2".
    /// </remarks>
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the BIC (Bank Identifier Code) associated with the iDEAL payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[A-Z]{6}[A-Z0-9]{2}([A-Z0-9]{3})?$.
    /// </remarks>
    [JsonPropertyName("bic")]
    [StringLength(11)]
    [RegularExpression("^[A-Z]{6}[A-Z0-9]{2}([A-Z0-9]{3})?$")]
    public string Bic { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the iDEAL payment experience.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional configuration for the payment experience.
    /// </remarks>
    [JsonPropertyName("experience_context")]
    public ExperienceContext ExperienceContext { get; set; }
}