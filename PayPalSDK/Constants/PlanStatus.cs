namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Represents the possible statuses for a subscription plan in the PayPal SDK.
/// </summary>
public class PlanStatus
{
    /// <summary>
    /// Indicates that the plan has been created but is not yet active.
    /// </summary>
    public const string CREATED = "CREATED";

    /// <summary>
    /// Indicates that the plan is inactive and cannot be used.
    /// </summary>
    public const string INACTIVE = "INACTIVE";

    /// <summary>
    /// Indicates that the plan is active and available for use.
    /// </summary>
    public const string ACTIVE = "ACTIVE";
}