using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Tracking;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;
 
/// <summary>
/// Provides methods for interacting with the PayPal Tracking API,
/// including adding, listing, and updating shipment trackers.
/// </summary>
public class TrackingClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of <see cref="TrackingClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PayPalHttpClient"/> used to send HTTP requests.</param>
    public TrackingClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Adds tracking information for one or more shipments.
    /// </summary>
    /// <param name="body">The request body containing the tracking details to add.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing a <see cref="TrackingAddResponseBody"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<TrackingAddResponseBody, ErrorResponse>> AddAsync(TrackingAddRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new TrackingAddRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists tracker information for a given transaction, with optional filters.
    /// </summary>
    /// <param name="transactionId">The ID of the transaction to retrieve trackers for.</param>
    /// <param name="trackingNumber">Optional. Filters results by a specific tracking number.</param>
    /// <param name="accountId">Optional. Filters results by a specific account ID.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing <see cref="TrackerInformation"/>
    /// on success, or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<TrackerInformation, ErrorResponse>> ListAsync(string transactionId, string? trackingNumber = null, string? accountId = null,
        CancellationToken cancellationToken = default)
    {
        var request = new TrackingListRequest(transactionId, trackingNumber, accountId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates an existing tracker identified by its ID.
    /// </summary>
    /// <param name="id">The unique identifier of the tracker to update.</param>
    /// <param name="body">The <see cref="Tracker"/> object containing the updated tracking information.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TError}"/> containing <c>true</c> if the update was successful,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateAsync(string id, Tracker body,
        CancellationToken cancellationToken = default)
    {
        var request = new TrackingUpdateRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }
}