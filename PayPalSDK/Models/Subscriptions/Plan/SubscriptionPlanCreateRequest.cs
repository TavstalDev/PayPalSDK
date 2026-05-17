using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan.Bodies;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan;

/// <summary>
/// Represents a request to create a subscription plan in the PayPal SDK.
/// </summary>
public class SubscriptionPlanCreateRequest : HttpRequestBase<SubscriptionPlanBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionPlanCreateRequest"/> class.
    /// </summary>
    /// <param name="body">The request body containing the details of the subscription plan to be created.</param>
    public SubscriptionPlanCreateRequest(SubscriptionPlanCreateRequestBody body)
        :
        base(HttpMethod.Post, $"/v1/billing/plans")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}