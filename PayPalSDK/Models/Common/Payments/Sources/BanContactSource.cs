using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a BanContact payment source within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class BanContactSource
{
    /// <summary>
    /// Gets or sets the name associated with the BanContact payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("name")]
    [StringLength(300)]
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the country code associated with the BanContact payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a valid two-letter country code or "C2".
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public string? CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the BanContact payment experience.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    public ExperienceContext? ExperienceContext { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}