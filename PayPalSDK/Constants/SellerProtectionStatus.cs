namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the possible statuses for seller protection in PayPal transactions.
/// </summary>
public class SellerProtectionStatus
{
    /// <summary>
    /// Indicates that the seller is fully eligible for protection.
    /// </summary>
    public const string ELIGIBLE = "ELIGIBLE";

    /// <summary>
    /// Indicates that the seller is partially eligible for protection.
    /// </summary>
    public const string PARTIALLY_ELIGIBLE = "PARTIALLY_ELIGIBLE";

    /// <summary>
    /// Indicates that the seller is not eligible for protection.
    /// </summary>
    public const string NOT_ELIGIBLE = "NOT_ELIGIBLE";
}