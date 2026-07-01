using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Provides shared HTTP execution methods for PayPal API clients.
/// </summary>
public interface IClient
{
    /// <summary>
    /// Sends a typed request and returns either a deserialized success payload or a structured PayPal error.
    /// </summary>
    /// <typeparam name="T">The expected success response model type.</typeparam>
    /// <param name="requestBase">The request object containing endpoint and serialization logic.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TFailure}"/> containing either the successful response body
    /// of type <typeparamref name="T"/> or an <see cref="ErrorResponse"/>.
    /// </returns>
    Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase,
        CancellationToken cancellationToken = default) where T : class;

    /// <summary>
    /// Sends a request where success is represented as a boolean value rather than a response body.
    /// </summary>
    /// <param name="requestBase">The request object containing endpoint and error deserialization logic.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TFailure}"/> containing <see langword="true"/> on success
    /// or an <see cref="ErrorResponse"/> when the request fails.
    /// </returns>
    Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase,
        CancellationToken cancellationToken = default);
}