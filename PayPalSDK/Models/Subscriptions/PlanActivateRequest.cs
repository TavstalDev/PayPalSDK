using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to activate a specific subscription plan.
/// </summary>
public class PlanActivateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanActivateRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to activate.</param>
    public PlanActivateRequest(string planId)
        :
        base(HttpMethod.Post, $"/v1/billing/plans/{planId}/activate")
    {
        // No content is needed for this request, as it simply activates the plan.
    }
}