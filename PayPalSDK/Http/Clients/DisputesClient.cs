using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Disputes;
using Tavstal.PayPalSDK.Models.Disputes;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for retrieving and managing PayPal customer disputes.
/// </summary>
public sealed class DisputesClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputesClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public DisputesClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Retrieves detailed information for a specific dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="DisputeDetails"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<DisputeDetails, ErrorResponse>> ShowDetailsAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new DisputeShowDetailsRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists disputes using time and paging filters.
    /// </summary>
    /// <param name="startTime">The start date-time for the search window.</param>
    /// <param name="disputedTransactionId">Optional transaction identifier associated with disputes.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="pageSize">The number of items per page.</param>
    /// <param name="nextPageToken">Optional token used to retrieve the next page.</param>
    /// <param name="disputeState">Optional dispute state filter.</param>
    /// <param name="createTimeBefore">Optional upper bound for dispute creation time.</param>
    /// <param name="createTimeAfter">Optional lower bound for dispute creation time.</param>
    /// <param name="updateTimeBefore">Optional upper bound for dispute update time.</param>
    /// <param name="updateTimeAfter">Optional lower bound for dispute update time.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="DisputeListResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<DisputeListResponseBody, ErrorResponse>> ListAsync(string startTime, string? disputedTransactionId = null, int page = 1, int pageSize = 10,
        string? nextPageToken = null, string? disputeState = null, string? createTimeBefore = null,
        string? createTimeAfter = null, string? updateTimeBefore = null,  string? updateTimeAfter = null, CancellationToken cancellationToken = default)
    {
        var request = new DisputeListRequest(startTime, disputedTransactionId, page, pageSize, nextPageToken, disputeState, 
            createTimeBefore, createTimeAfter, updateTimeBefore, updateTimeAfter);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Submits a settlement offer for a dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The offer details to submit.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> MakeOfferAsync(string id, DisputeMakeOfferRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new DisputeMakeOfferRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Accepts a claim in favor of the buyer for a dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The claim acceptance details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> AcceptClaimAsync(string id, DisputeAcceptClaimRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new DisputeAcceptClaimRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Provides evidence to support your side of a dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The evidence payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> ProvideEvidenceAsync(string id,
        DisputeProvideEvidenceRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeProvideEvidenceRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Accepts an offer made within a dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The offer acceptance details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> AcceptOfferAsync(string id,
        DisputeAcceptOfferRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeAcceptOfferRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Declines an offer made within a dispute.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The offer denial details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> DenyOfferAsync(string id,
        DisputeDenyOfferRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeDenyOfferRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Sends a message in the dispute conversation thread.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The message content payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> SendMessageAsync(string id,
        DisputeSendMessageRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeSendMessageRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Escalates a dispute to PayPal for adjudication.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The escalation details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> EscalateAsync(string id,
        DisputeEscalateRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeEscalateRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Submits an appeal for a previously resolved dispute decision.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The appeal details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> AppealAsync(string id, DisputeAppealRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new DisputeAppealRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Acknowledges receipt of a returned item in a dispute flow.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The return acknowledgment details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> AcknowledgeReturnAsync(string id,
        DisputeAcknowledgeReturnRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeAcknowledgeReturnRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Provides additional supporting information for a dispute case.
    /// </summary>
    /// <param name="id">The dispute identifier.</param>
    /// <param name="body">The support information payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="LinksResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<LinksResponseBody, ErrorResponse>> ProvideSupportAsync(string id,
        DisputeProvideSupportRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new DisputeProvideSupportRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }
}