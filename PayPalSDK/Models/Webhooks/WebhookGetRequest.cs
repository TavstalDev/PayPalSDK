using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common.Webhooks;

namespace Tavstal.PayPalSDK.Models.Webhooks;

/// <summary>
/// Represents an HTTP request for retrieving a specific webhook in the PayPal SDK.
/// </summary>
public class WebhookGetRequest : HttpRequestBase<Webhook>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookGetRequest"/> class.
    /// </summary>
    /// <param name="webhookId">The unique identifier of the webhook to retrieve.</param>
    public WebhookGetRequest(string webhookId)
        : base(HttpMethod.Get, $"/v1/notifications/webhooks/{webhookId}")
    {
        // No content is needed
    }
}