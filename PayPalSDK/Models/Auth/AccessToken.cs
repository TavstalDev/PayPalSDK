using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Auth;

/// <summary>
/// Represents an access token used for authentication with the PayPal API.
/// </summary>
[DataContract]
public class AccessToken
{
    /// <summary>
    /// The access token string provided by the PayPal API.
    /// </summary>
    [DataMember(Name = "access_token", EmitDefaultValue = false)]
    public string Token;

    /// <summary>
    /// The type of the token (e.g., Bearer).
    /// </summary>
    [DataMember(Name = "token_type", EmitDefaultValue = false)]
    public string TokenType;

    /// <summary>
    /// The duration in seconds until the token expires.
    /// </summary>
    [DataMember(Name = "expires_in", EmitDefaultValue = false)]
    public int ExpiresIn;

    /// <summary>
    /// The exact date and time when the token will expire.
    /// </summary>
    private readonly DateTime _expireDate;

    /// <summary>
    /// Initializes a new instance of the <see cref="AccessToken"/> class.
    /// Sets the expiration date based on the current time and the token's lifetime.
    /// </summary>
    public AccessToken()
    {
        var localDate = DateTime.Now;
        _expireDate = localDate.AddSeconds(ExpiresIn);
    }

    /// <summary>
    /// Determines whether the access token has expired.
    /// </summary>
    /// <returns><c>true</c> if the token has expired; otherwise, <c>false</c>.</returns>
    public bool IsExpired() => DateTime.Now >= _expireDate;
}