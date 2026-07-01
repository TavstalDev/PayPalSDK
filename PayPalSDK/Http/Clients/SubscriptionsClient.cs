using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Plans;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating, retrieving, updating, and managing PayPal subscriptions.
/// </summary>
public class SubscriptionsClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionsClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public SubscriptionsClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a new subscription.
    /// </summary>
    /// <param name="body">The subscription creation payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="SubscriptionBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<SubscriptionBody, ErrorResponse>> CreateAsync(SubscriptionCreateRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves details for a subscription.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="SubscriptionBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<SubscriptionBody, ErrorResponse>> GetAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionShowRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists subscriptions using optional filter and pagination parameters.
    /// </summary>
    /// <param name="planIds">Optional comma-separated plan identifiers to filter by.</param>
    /// <param name="statuses">Optional comma-separated subscription statuses to filter by.</param>
    /// <param name="createdAfet">Optional lower bound for creation time filter.</param>
    /// <param name="createdBefore">Optional upper bound for creation time filter.</param>
    /// <param name="updatedAfet">Optional lower bound for update time filter.</param>
    /// <param name="updatedBefore">Optional upper bound for update time filter.</param>
    /// <param name="filter">Optional custom filter expression.</param>
    /// <param name="pageSize">The number of records per page.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="customerIds">Optional customer identifiers to filter by.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="SubscriptionListResponse"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<SubscriptionListResponse, ErrorResponse>> ListAsync(string? planIds = null, string? statuses = null, string? createdAfet = null, string? createdBefore = null, 
        string? updatedAfet = null, string? updatedBefore = null, string? filter = null, int pageSize = 10, int page = 1, string[]? customerIds = null, 
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionListRequest(planIds, statuses, createdAfet, createdBefore, updatedAfet, updatedBefore, filter, pageSize, page, customerIds);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates a subscription using patch operations.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="body">A list of patch operations to apply.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateAsync(string id, List<UpdateOperation> body,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionUpdateRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Revises an active subscription.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="body">The revision payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="SubscriptionRevisedBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<SubscriptionRevisedBody, ErrorResponse>> ReviseAsync(string id,
        SubscriptionReviseRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionReviseRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Suspends a subscription.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="reason">The reason for suspension.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> SuspendAsync(string id, string reason,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionSuspendRequest(id, reason);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Cancels a subscription.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="reason">The reason for cancellation.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> CancelAsync(string id, string reason,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionCancelRequest(id, reason);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Reactivates a previously suspended subscription.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="reason">The reason for activation.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> ActivateAsync(string id, string reason,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionActivateRequest(id, reason);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Captures an outstanding subscription payment.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="body">The capture payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> CaptureAsync(string id, SubscriptionCaptureRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionCaptureRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists subscription transactions for a time range.
    /// </summary>
    /// <param name="id">The subscription identifier.</param>
    /// <param name="startTime">The start of the transaction time window.</param>
    /// <param name="endTime">The end of the transaction time window.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="SubscriptionListTransactionResponse"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<SubscriptionListTransactionResponse, ErrorResponse>> ListTransactionsAsync(string id, string startTime, string endTime,
        CancellationToken cancellationToken = default)
    {
        var request = new SubscriptionListTransactionRequest(id, startTime, endTime);
        return await ExecuteAsync(request, cancellationToken);
    }
}