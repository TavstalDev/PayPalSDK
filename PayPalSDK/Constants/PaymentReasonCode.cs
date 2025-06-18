namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the possible reason codes for a payment failure or issue.
/// </summary>
public class PaymentReasonCode
{
    /// <summary>
    /// Indicates that the payment was denied.
    /// </summary>
    public const string PAYMENT_DENIED = "PAYMENT_DENIED";

    /// <summary>
    /// Indicates that an internal server error occurred.
    /// </summary>
    public const string INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";

    /// <summary>
    /// Indicates that the payee's account is restricted.
    /// </summary>
    public const string PAYEE_ACCOUNT_RESTRICTED = "PAYEE_ACCOUNT_RESTRICTED";

    /// <summary>
    /// Indicates that the payer's account is restricted.
    /// </summary>
    public const string PAYER_ACCOUNT_RESTRICTED = "PAYER_ACCOUNT_RESTRICTED";

    /// <summary>
    /// Indicates that the payer is unable to make the payment.
    /// </summary>
    public const string PAYER_CANNOT_PAY = "PAYER_CANNOT_PAY";

    /// <summary>
    /// Indicates that the sending limit has been exceeded.
    /// </summary>
    public const string SENDING_LIMIT_EXCEEDED = "SENDING_LIMIT_EXCEEDED";

    /// <summary>
    /// Indicates that the transaction receiving limit has been exceeded.
    /// </summary>
    public const string TRANSACTION_RECEIVING_LIMIT_EXCEEDED = "TRANSACTION_RECEIVING_LIMIT_EXCEEDED";

    /// <summary>
    /// Indicates that there is a mismatch in the currency used for the transaction.
    /// </summary>
    public const string CURRENCY_MISMATCH = "CURRENCY_MISMATCH";
}