using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan;

/// <summary>
/// Represents a request to deactivate a specific subscription plan.
/// </summary>
public class SubscriptionPlanDeactivateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionPlanDeactivateRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to deactivate.</param>
    public SubscriptionPlanDeactivateRequest(string planId)
        : base(HttpMethod.Post, $"/v1/billing/plans/{planId}/deactivate")
    {
        // No content is needed for deactivation request
    }
}