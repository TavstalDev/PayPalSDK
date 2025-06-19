using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.Webhooks;

/// <summary>
/// Represents an HTTP request for verifying a webhook signature in the PayPal SDK.
/// </summary>
public class WebhookVerifyRequest : HttpRequestBase<WebhookVerifyResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookVerifyRequest"/> class.
    /// </summary>
    /// <param name="body">
    /// The request body containing the data required to verify the webhook signature.
    /// </param>
    public WebhookVerifyRequest(WebhokVerifyRequestBody body)
        : base(HttpMethod.Post, $"/v1/notifications/verify-webhook-signature")
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = System.Net.Http.Json.JsonContent.Create(body, options: new System.Text.Json.JsonSerializerOptions
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        });
    }
}