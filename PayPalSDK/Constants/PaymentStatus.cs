namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the possible statuses of a payment.
/// </summary>
public class PaymentStatus
{
    /// <summary>
    /// Indicates that the payment has been completed successfully.
    /// </summary>
    public const string COMPLETED = "COMPLETED";

    /// <summary>
    /// Indicates that the payment has been declined.
    /// </summary>
    public const string DECLINED = "DECLINED";

    /// <summary>
    /// Indicates that the payment has been partially refunded.
    /// </summary>
    public const string PARTIALLY_REFUNDED = "PARTIALLY_REFUNDED";

    /// <summary>
    /// Indicates that the payment is pending and has not been completed yet.
    /// </summary>
    public const string PENDING = "PENDING";

    /// <summary>
    /// Indicates that the payment has been fully refunded.
    /// </summary>
    public const string REFUNDED = "REFUNDED";
}