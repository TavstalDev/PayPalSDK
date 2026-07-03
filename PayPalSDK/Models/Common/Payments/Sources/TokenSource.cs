using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a token-based payment source in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TokenSource
{
    /// <summary>
    /// Gets or sets the unique identifier for the token source.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("id")]
    [StringLength(255)]
    [Required]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the type of the token source.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("type")]
    [StringLength(255)]
    public string? Type { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}