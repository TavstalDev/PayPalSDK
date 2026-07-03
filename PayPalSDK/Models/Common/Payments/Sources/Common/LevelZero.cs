using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents a Level Zero payment source within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class LevelZero
{
    /// <summary>
    /// Gets or sets the authorization code for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 6 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("auth_code")]
    [StringLength(6)]
    [Required]
    public string? AuthCode { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}