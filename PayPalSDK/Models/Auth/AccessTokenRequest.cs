using System.Net.Http.Headers;
using Tavstal.PayPalSDK.Config;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Auth;

/// <summary>
/// Represents a request to obtain an access token from the PayPal API.
/// </summary>
public class AccessTokenRequest : HttpRequestBase<AccessToken>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccessTokenRequest"/> class.
    /// </summary>
    /// <param name="environment">The environment configuration containing authorization details.</param>
    /// <param name="refreshToken">An optional refresh token for obtaining a new access token.</param>
    public AccessTokenRequest(EnvironmentBase environment, string? refreshToken = null)
        :
        base(HttpMethod.Post, "/v1/oauth2/token")
    {
        // Sets the Authorization header using the environment's authorization string.
        Headers.Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());

        // Creates a dictionary to hold the request parameters.
        var dictionary = new Dictionary<string, string?>
        {
            { "grant_type", "client_credentials" } // Default grant type for client credentials.
        };

        // If a refresh token is provided, updates the grant type and adds the refresh token to the dictionary.
        if (refreshToken != null)
        {
            dictionary["grant_type"] = "refresh_token";
            dictionary.Add("refresh_token", refreshToken);
        }

        // Sets the request content as form URL-encoded data.
        Content = new FormUrlEncodedContent(dictionary);
    }
}