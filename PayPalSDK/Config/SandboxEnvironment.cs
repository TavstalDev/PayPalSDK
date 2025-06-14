namespace Tavstal.PayPalSDK.Config;

/// <summary>
/// Represents the sandbox environment configuration for PayPal API.
/// </summary>
public class SandboxEnvironment : EnvironmentBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SandboxEnvironment"/> class.
    /// </summary>
    /// <param name="clientId">The client ID for the PayPal application.</param>
    /// <param name="clientSecret">The client secret for the PayPal application.</param>
    public SandboxEnvironment(string clientId, string clientSecret)
        : base(clientId, clientSecret, "https://api.sandbox.paypal.com", "https://www.sandbox.paypal.com")
    {
        // Base constructor initializes the environment with sandbox PayPal API and website URLs.
    }
}