namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Provides constants for card verification methods in the PayPal SDK.
/// </summary>
public class CardVerificationMethods
{
    /// <summary>
    /// Represents the Strong Customer Authentication (SCA) method that is always required.
    /// </summary>
    public const string SCA_ALWAYS = "SCA_ALWAYS";

    /// <summary>
    /// Represents the Strong Customer Authentication (SCA) method that is required only when necessary.
    /// </summary>
    public const string SCA_WHEN_REQUIRED = "SCA_WHEN_REQUIRED";

    /// <summary>
    /// Represents the 3D Secure card verification method.
    /// </summary>
    public const string THREED_SECURE = "3D_SECURE";

    /// <summary>
    /// Represents the Address Verification System (AVS) and Card Verification Value (CVV) method.
    /// </summary>
    public const string AVS_CVV = "AVS_CVV";
}