using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to revise a subscription.
/// </summary>
public class SubscriptionReviseRequest : HttpRequestBase<SubscriptionRevisedBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionReviseRequest"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the subscription to be revised.</param>
    /// <param name="body">The body of the request containing the revised subscription details.</param>
    /// <remarks>
    /// This request uses the HTTP POST method and sets the request content using JSON serialization.
    /// Null values in the body are ignored during serialization.
    /// </remarks>
    public SubscriptionReviseRequest(string id, SubscriptionReviseRequestBody body)
        :
        base(HttpMethod.Post, $"/v1/billing/subscriptions/{id}/revise")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.SubscriptionReviseRequestBody);
    }
}