using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents a network token object in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class NetworkToken
{
    /// <summary>
    /// Gets or sets the network token number.
    /// </summary>
    /// <remarks>
    /// This field is required, has a maximum length of 19 characters, and represents the tokenized card number.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("number")]
    [StringLength(19)]
    [Required]
    public string? Number { get; set; }

    /// <summary>
    /// Gets or sets the cryptogram associated with the network token.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 32 characters, and represents the cryptographic value for the token.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("cryptogram")]
    [StringLength(32)]
    public string? Cryptogram { get; set; }

    /// <summary>
    /// Gets or sets the token requestor ID.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 11 characters, and identifies the entity requesting the token.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("token_requestor_id")]
    [StringLength(11)]
    public string? TokenRequestorId { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the network token.
    /// </summary>
    /// <remarks>
    /// This field is required, has a maximum length of 7 characters, and must match the format YYYY-MM (e.g., 2023-12).
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("expiry")]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public string? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the Electronic Commerce Indicator (ECI) flag.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("eci_flag")]
    public EEciFlag? EciFlag { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}