using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan.Bodies;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan;

/// <summary>
/// Represents a request to retrieve details of a specific subscription plan.
/// </summary>
public class SubscriptionPlanShowRequest : HttpRequestBase<SubscriptionPlanBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionPlanShowRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to retrieve.</param>
    public SubscriptionPlanShowRequest(string planId)
        : base(HttpMethod.Get, $"/v1/billing/plans/{planId}") 
    { }
}