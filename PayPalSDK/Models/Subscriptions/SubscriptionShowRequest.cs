using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents a request to retrieve subscription details.
/// </summary>
public class SubscriptionShowRequest : HttpRequestBase<SubscriptionBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionShowRequest"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the subscription.</param>
    /// <remarks>
    /// This request uses the HTTP GET method and does not require a request body.
    /// </remarks>
    public SubscriptionShowRequest(string id)
        :
        base(HttpMethod.Get, $"/v1/billing/subscriptions/{id}")
    {
        // No body is needed for this request
    }
}