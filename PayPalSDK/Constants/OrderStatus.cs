namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the possible statuses of an order within the PayPal SDK.
/// </summary>
public class OrderStatus
{
    /// <summary>
    /// Indicates that the order has been created.
    /// </summary>
    public const string CREATED = "CREATED";

    /// <summary>
    /// Indicates that the order has been saved.
    /// </summary>
    public const string SAVED = "SAVED";

    /// <summary>
    /// Indicates that the order has been approved.
    /// </summary>
    public const string APPROVED = "APPROVED";

    /// <summary>
    /// Indicates that the order has been voided.
    /// </summary>
    public const string VOIDED = "VOIDED";

    /// <summary>
    /// Indicates that the order has been completed.
    /// </summary>
    public const string COMPLETED = "COMPLETED";

    /// <summary>
    /// Indicates that the payer needs to take action for the order.
    /// </summary>
    public const string PAYER_ACTION_REQUIRED = "PAYER_ACTION_REQUIRED";
}