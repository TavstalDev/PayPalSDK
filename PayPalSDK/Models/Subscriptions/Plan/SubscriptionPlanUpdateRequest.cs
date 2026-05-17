using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan;

/// <summary>
/// Represents a request to update a specific subscription plan.
/// </summary>
public class SubscriptionPlanUpdateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionPlanUpdateRequest"/> class.
    /// </summary>
    /// <param name="planId">The unique identifier of the subscription plan to update.</param>
    /// <param name="body">A list of update operations to apply to the subscription plan.</param>
    public SubscriptionPlanUpdateRequest(string planId, List<UpdateOperation> body)
        : base(HttpMethod.Patch, $"/v1/billing/plans/{planId}")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}