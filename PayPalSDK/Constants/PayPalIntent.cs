namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the PayPal intent types in the PayPal SDK.
/// </summary>
public static class PayPalIntent
{
    /// <summary>
    /// Represents the intent to capture payment immediately.
    /// </summary>
    public const string CAPTURE = "CAPTURE";

    /// <summary>
    /// Represents the intent to authorize payment for later capture.
    /// </summary>
    public const string AUTHORIZE = "AUTHORIZE";
}