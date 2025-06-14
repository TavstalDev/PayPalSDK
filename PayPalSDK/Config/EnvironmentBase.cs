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
    private readonly string _baseUrl;

    /// <summary>
    /// The client ID for the PayPal application.
    /// </summary>
    private readonly string _clientId;

    /// <summary>
    /// The client secret for the PayPal application.
    /// </summary>
    private readonly string _clientSecret;

    /// <summary>
    /// The web URL for the PayPal website.
    /// </summary>
    private readonly string _webUrl;

    /// <summary>
    /// Initializes a new instance of the <see cref="EnvironmentBase"/> class.
    /// </summary>
    /// <param name="baseUrl">The base URL for the PayPal API.</param>
    /// <param name="clientId">The client ID for the PayPal application.</param>
    /// <param name="clientSecret">The client secret for the PayPal application.</param>
    /// <param name="webUrl">The web URL for the PayPal website.</param>
    protected EnvironmentBase(string baseUrl, string clientId, string clientSecret, string webUrl)
    {
        _baseUrl = baseUrl;
        _clientId = clientId;
        _clientSecret = clientSecret;
        _webUrl = webUrl;
    }

    /// <summary>
    /// Gets the base URL for the PayPal API.
    /// </summary>
    public string BaseUrl => _baseUrl;

    /// <summary>
    /// Gets the client ID for the PayPal application.
    /// </summary>
    public string ClientId => _clientId;

    /// <summary>
    /// Gets the web URL for the PayPal website.
    /// </summary>
    public string WebUrl => _webUrl;

    /// <summary>
    /// Generates the authorization string for the PayPal API.
    /// </summary>
    /// <returns>A Base64-encoded string containing the client ID and client secret.</returns>
    public string AuthorizationString()
    {
        return Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}")
            );
    }
}