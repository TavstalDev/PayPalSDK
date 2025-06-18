namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Provides constants representing various transaction methods for PayPal.
/// </summary>
public class TransactionMethod
{
    /// <summary>
    /// Represents a bank transfer transaction method.
    /// </summary>
    public const string BANK_TRANSFER = "BANK_TRANSFER";

    /// <summary>
    /// Represents a cash transaction method.
    /// </summary>
    public const string CASH = "CASH";

    /// <summary>
    /// Represents a check transaction method.
    /// </summary>
    public const string CHECK = "CHECK";

    /// <summary>
    /// Represents a credit card transaction method.
    /// </summary>
    public const string CREDIT_CARD = "CREDIT_CARD";

    /// <summary>
    /// Represents a debit card transaction method.
    /// </summary>
    public const string DEBIT_CARD = "DEBIT_CARD";

    /// <summary>
    /// Represents a PayPal transaction method.
    /// </summary>
    public const string PAYPAL = "PAYPAL";

    /// <summary>
    /// Represents a wire transfer transaction method.
    /// </summary>
    public const string WIRE_TRANSFER = "WIRE_TRANSFER";

    /// <summary>
    /// Represents an unspecified or other transaction method.
    /// </summary>
    public const string OTHER = "OTHER";
}