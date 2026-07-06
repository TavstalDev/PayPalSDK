using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Auth;

/// <summary>
/// Represents an access token used for authentication with the PayPal API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class AccessToken
{
    /// <summary>
    /// The access token string provided by the PayPal API.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("access_token")]
    [Required]
    public string? Token { get; set; }

    /// <summary>
    /// The type of the token (e.g., Bearer).
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }

    /// <summary>
    /// The duration in seconds until the token expires.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Gets the date and time when the access token was created.
    /// </summary>
    [JsonIgnore] 
    public DateTime CreatedAt { get; } = DateTime.UtcNow;

    /// <summary>
    /// Determines whether the access token has expired.
    /// </summary>
    /// <returns><c>true</c> if the token has expired; otherwise, <c>false</c>.</returns>
    public bool IsExpired() => DateTime.UtcNow >= CreatedAt.AddSeconds(ExpiresIn - 60);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}