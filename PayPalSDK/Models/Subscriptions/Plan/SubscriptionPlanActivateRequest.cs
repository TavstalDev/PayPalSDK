using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan;

/// <summary>
/// Represents a request to activate a specific subscription plan.
/// </summary>
public class SubscriptionPlanActivateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionPlanActivateRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to activate.</param>
    public SubscriptionPlanActivateRequest(string planId)
        :
        base(HttpMethod.Post, $"/v1/billing/plans/{planId}/activate")
    {
        // No content is needed for this request, as it simply activates the plan.
    }
}