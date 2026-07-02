using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Webhooks;
using Tavstal.PayPalSDK.Models.Webhooks;
using Tavstal.PayPalSDK.Models.Webhooks.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides methods for managing PayPal webhooks, including creation, retrieval,
/// listing, updates, deletion, and event signature verification.
/// </summary>
public sealed class WebhooksClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of <see cref="WebhooksClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="IPayPalHttpClient"/> used to send HTTP requests.</param>
    public WebhooksClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a new webhook for the configured application.
    /// </summary>
    /// <param name="body">The request payload that defines the webhook URL and subscribed events.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing the created <see cref="WebhookBody"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<WebhookBody, ErrorResponse>> CreateAsync(WebhookCreateRequestBody body, 
        CancellationToken cancellationToken = default)
    {
        var request = new WebhookCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves a webhook by its unique identifier.
    /// </summary>
    /// <param name="id">The webhook ID.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing the matching <see cref="WebhookBody"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<WebhookBody, ErrorResponse>> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new WebhookGetRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists webhooks associated with the specified anchor type.
    /// </summary>
    /// <param name="anchorType">
    /// The anchor type used for filtering. Defaults to <c>"APPLICATION"</c>.
    /// </param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing a <see cref="WebhookListResponseBody"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<WebhookListResponseBody, ErrorResponse>> ListAsync(string anchorType = "APPLICATION", 
        CancellationToken cancellationToken = default)
    {
        var request = new WebhookListRequest(anchorType);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates a webhook using a list of patch operations.
    /// </summary>
    /// <param name="webhookId">The ID of the webhook to update.</param>
    /// <param name="body">A list of patch operations describing the update changes.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing the updated <see cref="Webhook"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<Webhook, ErrorResponse>> UpdateAsync(string webhookId, List<UpdateOperation> body,
        CancellationToken cancellationToken = default)
    {
        var request = new WebhookUpdateRequest(webhookId, body);
        return await ExecuteAsync(request, cancellationToken);
    }
    
    /// <summary>
    /// Deletes a webhook by its ID.
    /// </summary>
    /// <param name="webhookId">The ID of the webhook to delete.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing <c>true</c> if deletion succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteAsync(string webhookId, CancellationToken cancellationToken = default)
    {
        var request = new WebhookDeleteRequest(webhookId);
        return await ExecuteAsync(request, cancellationToken);
    }
    
    /// <summary>
    /// Verifies that a webhook event notification was sent by PayPal.
    /// </summary>
    /// <param name="body">The verification payload including transmission and event details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing <see cref="WebhookVerifyResponseBody"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<WebhookVerifyResponseBody, ErrorResponse>> VerifyAsync(WebhookVerifyRequestBody body, 
        CancellationToken cancellationToken = default)
    {
        var request = new WebhookVerifyRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }
}