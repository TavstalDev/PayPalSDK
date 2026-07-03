using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents a OneClick payment source within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class OneClick
{
    /// <summary>
    /// Gets or sets the authorization code for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 6 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("auth_code")]
    [StringLength(6)]
    public string? AuthCode { get; set; }

    /// <summary>
    /// Gets or sets the consumer reference associated with the payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 64 characters.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("consumer_reference")]
    [StringLength(64)]
    public string? ConsumerReference { get; set; }

    /// <summary>
    /// Gets or sets the alias label for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 35 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("alias_label")]
    [StringLength(35)]
    public string? AliasLabel { get; set; }

    /// <summary>
    /// Gets or sets the alias key for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 19 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("alias_key")]
    [StringLength(19)]
    public string? AliasKey { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}