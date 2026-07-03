using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents information about a user's name.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class NameInfo
{
    /// <summary>
    /// Gets or sets the prefix of the user's name (e.g., "Mr.", "Dr.").
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("prefix")]
    [StringLength(140)]
    public string? Prefix { get; set; }

    /// <summary>
    /// Gets or sets the user's given name (first name).
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("given_name")]
    [StringLength(140)]
    public string? GivenName { get; set; }

    /// <summary>
    /// Gets or sets the user's surname (last name).
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("surname")]
    [StringLength(140)]
    public string? Surname { get; set; }

    /// <summary>
    /// Gets or sets the user's middle name.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("middle_name")]
    [StringLength(140)]
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the suffix of the user's name (e.g., "Jr.", "III").
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("suffix")]
    [StringLength(140)]
    public string? Suffix { get; set; }

    /// <summary>
    /// Gets or sets an alternate full name for the user.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("alternate_full_name")]
    [StringLength(300)]
    public string? AlternateFullName { get; set; }

    /// <summary>
    /// Gets or sets the full name of the user.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("full_name")]
    [StringLength(300)]
    public string? FullName { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}