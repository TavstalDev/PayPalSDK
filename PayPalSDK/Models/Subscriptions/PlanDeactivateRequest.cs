using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to deactivate a specific subscription plan.
/// </summary>
public class PlanDeactivateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanDeactivateRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to deactivate.</param>
    public PlanDeactivateRequest(string planId)
        : base(HttpMethod.Post, $"/v1/billing/plans/{planId}/deactivate")
    {
        // No content is needed for deactivation request
    }
}