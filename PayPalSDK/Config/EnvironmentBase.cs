using System.Text;

namespace Tavstal.PayPalSDK.Config;

/// <summary>
/// Represents the base configuration for PayPal environments.
/// </summary>
public class EnvironmentBase
{
    /// <summary>
    /// The base URL for the PayPal API.
    /// </summary>
    public string BaseUrl { get; }

    /// <summary>
    /// The client ID for the PayPal application.
    /// </summary>
    public string ClientId { get; }

    /// <summary>
    /// The client secret for the PayPal application.
    /// </summary>
    public string ClientSecret { get; }

    /// <summary>
    /// The web URL for the PayPal website.
    /// </summary>
    public string WebUrl { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EnvironmentBase"/> class.
    /// </summary>
    /// <param name="baseUrl">The base URL for the PayPal API.</param>
    /// <param name="clientId">The client ID for the PayPal application.</param>
    /// <param name="clientSecret">The client secret for the PayPal application.</param>
    /// <param name="webUrl">The web URL for the PayPal website.</param>
    protected EnvironmentBase(string baseUrl, string clientId, string clientSecret, string webUrl)
    {
        if (string.IsNullOrEmpty(baseUrl))
            throw new ArgumentException("Base URL cannot be null or empty.", nameof(baseUrl));
        if (string.IsNullOrEmpty(clientId))
            throw new ArgumentException("Client ID cannot be null or empty.", nameof(clientId));
        if (string.IsNullOrEmpty(clientSecret))
            throw new ArgumentException("Client secret cannot be null or empty.", nameof(clientSecret));
        if (string.IsNullOrEmpty(webUrl))
            throw new ArgumentException("Web URL cannot be null or empty.", nameof(webUrl));
        
        BaseUrl = baseUrl;
        ClientId = clientId;
        ClientSecret = clientSecret;
        WebUrl = webUrl;
    }

    /// <summary>
    /// Generates the authorization string for the PayPal API.
    /// </summary>
    /// <returns>A Base64-encoded string containing the client ID and client secret.</returns>
    internal string AuthorizationString()
    {
        return Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")
            );
    }
}