namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Provides constants for payment types in the PayPal SDK.
/// </summary>
public class PaymentType
{
    /// <summary>
    /// Represents a one-time payment.
    /// </summary>
    public const string ONE_TIME = "ONE_TIME";

    /// <summary>
    /// Represents a recurring payment.
    /// </summary>
    public const string RECURRING = "RECURRING";

    /// <summary>
    /// Represents an unscheduled payment.
    /// </summary>
    public const string UNSCHEDULED = "UNSCHEDULED";
}