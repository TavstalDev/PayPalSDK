namespace Tavstal.PayPalSDK.Config;

/// <summary>
/// Represents the live environment configuration for PayPal API.
/// </summary>
public class LiveEnvironment : EnvironmentBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LiveEnvironment"/> class.
    /// </summary>
    /// <param name="clientId">The client ID for the PayPal application.</param>
    /// <param name="clientSecret">The client secret for the PayPal application.</param>
    public LiveEnvironment(string clientId, string clientSecret)
        : base(clientId, clientSecret, "https://api.paypal.com", "https://www.paypal.com")
    {
        // Base constructor initializes the environment with live PayPal API and website URLs.
    }
}