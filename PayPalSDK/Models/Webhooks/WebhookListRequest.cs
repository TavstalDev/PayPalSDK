using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Webhooks;

/// <summary>
/// Represents an HTTP request for listing webhooks in the PayPal SDK.
/// </summary>
public class WebhookListRequest : HttpRequestBase<WebhookListResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookListRequest"/> class.
    /// </summary>
    /// <param name="anchorType">The anchor type used to filter the webhooks. Default is "APPLICATION".</param>
    public WebhookListRequest(string anchorType = "APPLICATION")
        :
        base(HttpMethod.Get, $"/v1/notifications/webhooks?anchor_type={anchorType}")
    {
        // No body is required
    }
}