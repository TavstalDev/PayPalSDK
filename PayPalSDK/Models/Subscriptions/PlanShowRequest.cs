using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to retrieve details of a specific subscription plan.
/// </summary>
public class PlanShowRequest : HttpRequestBase<PlanBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanShowRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to retrieve.</param>
    public PlanShowRequest(string planId)
        : base(HttpMethod.Get, $"/v1/billing/plans/{planId}")
    {
    }
}