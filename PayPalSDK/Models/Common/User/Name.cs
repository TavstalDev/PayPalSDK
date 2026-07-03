using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents a name object in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Name
{
    /// <summary>
    /// Gets or sets the given name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("given_name")]
    [StringLength(140)]
    public string? GivenName { get; set; }

    /// <summary>
    /// Gets or sets the surname.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("surname")]
    [StringLength(140)]
    public string? Surname { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}