namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the different types of cards supported within the PayPal SDK.
/// </summary>
public class CardType
{
    /// <summary>
    /// Represents a credit card type.
    /// </summary>
    public const string CREDIT = "CREDIT";

    /// <summary>
    /// Represents a debit card type.
    /// </summary>
    public const string DEBIT = "DEBIT";

    /// <summary>
    /// Represents a prepaid card type.
    /// </summary>
    public const string PREPAID = "PREPAID";

    /// <summary>
    /// Represents a store card type.
    /// </summary>
    public const string STORE = "STORE";

    /// <summary>
    /// Represents an unknown card type.
    /// </summary>
    public const string UNKNOWN = "UNKNOWN";
}