using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Provides shared HTTP execution helpers for concrete PayPal API clients.
/// </summary>
public abstract class ClientBase
{
    /// <summary>
    /// The underlying PayPal HTTP client used to send API requests.
    /// </summary>
    protected readonly PayPalHttpClient _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientBase"/> class.
    /// </summary>
    /// <param name="client">The configured <see cref="PayPalHttpClient"/> used for outgoing requests.</param>
    protected ClientBase(PayPalHttpClient client)
    {
        _client = client;
    }

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
    /// <exception cref="OperationCanceledException">Thrown when the operation is canceled.</exception>
    protected async Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase, CancellationToken cancellationToken = default) where T : class
    {
        var response = await _client.SendAsync(requestBase, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            try
            {
                var errorResponse = await requestBase.GetErrorResponseAsync(response, cancellationToken);
                if (errorResponse == null)
                    throw new Exception(
                        "Failed to parse PayPal error response, the request probably did not reach PayPal's server.");

                return Result<T, ErrorResponse>.Failure(errorResponse);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (HttpRequestException ex)
            {
                return Result<T, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = $"HTTP Error, Status Code: {ex.StatusCode}",
                    Message = ex.Message,
                });
            }
            catch (Exception ex)
            {
                return Result<T, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = "Unexpected error occured while deserializing error response.",
                    Message = ex.Message,
                });
            }
        }
        
        try
        {
            var responseBody = await requestBase.GetResponseBodyAsync(response, cancellationToken);
            if (responseBody == null)
                throw new Exception("Failed to deserialize success response body.");

            return Result<T, ErrorResponse>.Success(responseBody);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            return Result<T, ErrorResponse>.Failure(new ErrorResponse
            {
                Name = "Unexpected error occured while deserializing success response body.",
                Message = ex.Message,
            });
        }
    }
    
    /// <summary>
    /// Sends a request where success is represented as a boolean value rather than a response body.
    /// </summary>
    /// <param name="requestBase">The request object containing endpoint and error deserialization logic.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="Result{TSuccess,TFailure}"/> containing <see langword="true"/> on success
    /// or an <see cref="ErrorResponse"/> when the request fails.
    /// </returns>
    /// <exception cref="OperationCanceledException">Thrown when the operation is canceled.</exception>
    protected async Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase, CancellationToken cancellationToken = default)
    {
        var response = await _client.SendAsync(requestBase, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            try
            {
                var errorResponse = await requestBase.GetErrorResponseAsync(response, cancellationToken);
                if (errorResponse == null)
                    throw new Exception(
                        "Failed to parse PayPal error response, the request probably did not reach PayPal's server.");

                return Result<bool, ErrorResponse>.Failure(errorResponse);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (HttpRequestException ex)
            {
                return Result<bool, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = $"HTTP Error, Status Code: {ex.StatusCode}",
                    Message = ex.Message,
                });
            }
            catch (Exception ex)
            {
                return Result<bool, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = "Unexpected error occured while deserializing error response.",
                    Message = ex.Message,
                });
            }
        }
        return Result<bool, ErrorResponse>.Success(true);
    }
}