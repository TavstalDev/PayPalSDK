namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Provides constants for Electronic Commerce Indicator (ECI) flags in the PayPal SDK.
/// </summary>
public class EciFlags
{
    /// <summary>
    /// Represents a Mastercard non-3D Secure transaction.
    /// </summary>
    public const string MASTERCARD_NON_3D_SECURE_TRANSACTION = "MASTERCARD_NON_3D_SECURE_TRANSACTION";

    /// <summary>
    /// Represents a Mastercard attempted authentication transaction.
    /// </summary>
    public const string MASTERCARD_ATTEMPTED_AUTHENTICATION_TRANSACTION = "MASTERCARD_ATTEMPTED_AUTHENTICATION_TRANSACTION";

    /// <summary>
    /// Represents a Mastercard fully authenticated transaction.
    /// </summary>
    public const string MASTERCARD_FULLY_AUTHENTICATED_TRANSACTION = "MASTERCARD_FULLY_AUTHENTICATED_TRANSACTION";

    /// <summary>
    /// Represents a fully authenticated transaction for VISA, AMEX, JCB, or DINERS CLUB.
    /// </summary>
    public const string FULLY_AUTHENTICATED_TRANSACTION = "FULLY_AUTHENTICATED_TRANSACTION";

    /// <summary>
    /// Represents an attempted authentication transaction for VISA, AMEX, JCB, or DINERS CLUB.
    /// </summary>
    public const string ATTEMPTED_AUTHENTICATION_TRANSACTION = "ATTEMPTED_AUTHENTICATION_TRANSACTION";

    /// <summary>
    /// Represents a non-3D Secure transaction for VISA, AMEX, JCB, or DINERS CLUB.
    /// </summary>
    public const string NON_3D_SECURE_TRANSACTION = "NON_3D_SECURE_TRANSACTION";
}