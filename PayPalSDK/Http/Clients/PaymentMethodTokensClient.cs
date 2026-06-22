using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating, retrieving, listing, and deleting PayPal payment method tokens.
/// </summary>
public class PaymentMethodTokensClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentMethodTokensClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public PaymentMethodTokensClient(PayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a payment method token.
    /// </summary>
    /// <param name="body">The token creation payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="PaymentToken"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentToken, ErrorResponse>> CreateAsync(PaymentTokenCreateRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves a payment method token by identifier.
    /// </summary>
    /// <param name="id">The payment token identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the requested <see cref="PaymentToken"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentToken, ErrorResponse>> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenRetrieveRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Creates a payment method token setup resource.
    /// </summary>
    /// <param name="body">The setup creation payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="PaymentTokenSetup"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentTokenSetup, ErrorResponse>> CreateSetupAsync(PaymentTokenCreateRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenSetupCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves a payment method token setup resource by identifier.
    /// </summary>
    /// <param name="id">The payment token setup identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the requested <see cref="PaymentTokenSetup"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentTokenSetup, ErrorResponse>> GetSetupAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenSetupRetrieveRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }
    
    /// <summary>
    /// Lists payment method tokens for a specific customer.
    /// </summary>
    /// <param name="customerId">The customer identifier whose tokens should be returned.</param>
    /// <param name="pageSize">The number of items to return per page.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="totalRequired">Whether the response should include total count metadata.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="PaymentTokenListAllResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<PaymentTokenListAllResponseBody, ErrorResponse>> ListAsync(string customerId, int pageSize = 5, int page = 1, bool totalRequired = false, CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenListAllRequest(customerId, pageSize, page, totalRequired);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Deletes a payment method token.
    /// </summary>
    /// <param name="id">The payment token identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> on successful deletion,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        var request = new PaymentTokenDeleteRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }
}