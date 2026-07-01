using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for managing payment resources.
/// </summary>
public class PaymentResourcesClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourcesClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public PaymentResourcesClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a new payment resource.
    /// </summary>
    /// <param name="body">The payload containing payment resource creation details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="PaymentResourceBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentResourceBody, ErrorResponse>> CreateAsync(PaymentResourceCreateRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentResourceCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves a payment resource by identifier.
    /// </summary>
    /// <param name="id">The payment resource identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the requested <see cref="PaymentResourceBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentResourceBody, ErrorResponse>> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new PaymentResourceRetrieveRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists payment resources with optional pagination controls.
    /// </summary>
    /// <param name="pageSize">The number of resources to return per page.</param>
    /// <param name="pageToken">The token that identifies the next page to retrieve.</param>
    /// <param name="totalRequired">Indicates whether total count metadata should be included.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="PaymentResourceListResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentResourceListResponseBody, ErrorResponse>> ListAsync(int pageSize = 10, string? pageToken = null, bool totalRequired = false, 
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentResourceListRequest(pageSize, pageToken);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Replaces or updates an existing payment resource.
    /// </summary>
    /// <param name="id">The payment resource identifier.</param>
    /// <param name="body">The payload describing replacement values.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> when the update succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateAsync(string id, PaymentResourceReplaceRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentResourceReplaceRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Deletes a payment resource.
    /// </summary>
    /// <param name="id">The payment resource identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> when the deletion succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new PaymentResourceDeleteRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }
}