using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Auth;

/// <summary>
/// Represents a refresh token response from the PayPal authentication API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class RefreshToken
{
    /// <summary>
    /// The refresh token string.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("refresh_token")]
    [Required]
    public string? Token { get; set; }

    /// <summary>
    /// The type of the token.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }

    /// <summary>
    /// The expiration time of the token in seconds.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("expires_in")]
    public string? ExpiresIn { get; set; }

    /// <summary>
    /// The ID token.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("id_token")]
    public string? IdToken { get; set; }
    
    /// <summary>
    /// Converts the current <see cref="RefreshToken"/> instance to an <see cref="AccessToken"/> instance.
    /// </summary>
    /// <returns>
    /// An <see cref="AccessToken"/> object containing the token, token type, and expiration time.
    /// If the expiration time is not a valid integer, it defaults to 0.
    /// </returns>
    public AccessToken ToAccessToken()
    {
        return new AccessToken
        {
            Token = Token,
            TokenType = TokenType,
            ExpiresIn = int.TryParse(ExpiresIn, out var expiresIn) ? expiresIn : 0
        };
    }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}