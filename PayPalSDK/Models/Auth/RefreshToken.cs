using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Auth;

[DataContract]
public class RefreshToken
{
    /// <summary>
    /// The refresh token string.
    /// </summary>
    [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
    public string Token;

    /// <summary>
    /// The type of the token.
    /// </summary>
    [DataMember(Name = "token_type", EmitDefaultValue = false)]
    public string TokenType;

    /// <summary>
    /// The expiration time of the token in seconds.
    /// </summary>
    [DataMember(Name = "expires_in", EmitDefaultValue = false)]
    public string ExpiresIn;

    /// <summary>
    /// The ID token.
    /// </summary>
    [DataMember(Name = "id_token", EmitDefaultValue = false)]
    public string IdToken;

    /// <summary>
    /// Initializes a new instance of the <see cref="RefreshToken"/> class.
    /// </summary>
    /// <param name="token">The refresh token string.</param>
    /// <param name="tokenType">The type of the token.</param>
    /// <param name="expiresIn">The expiration time of the token in seconds.</param>
    /// <param name="idToken">The ID token.</param>
    public RefreshToken(string token, string tokenType, string expiresIn, string idToken)
    {
        Token = token;
        TokenType = tokenType;
        ExpiresIn = expiresIn;
        IdToken = idToken;
    }
    
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
}