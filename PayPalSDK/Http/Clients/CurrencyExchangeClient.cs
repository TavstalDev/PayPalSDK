using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.CurrencyExchange;
using Tavstal.PayPalSDK.Models.CurrencyExchange.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating currency exchange quotes through the PayPal API.
/// </summary>
public sealed class CurrencyExchangeClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyExchangeClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public CurrencyExchangeClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a currency exchange quote based on the provided source and target currency details.
    /// </summary>
    /// <param name="body">The request payload containing currency exchange parameters.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="CurrencyExchangeCreateResponseBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<CurrencyExchangeCreateResponseBody, ErrorResponse>> CreateAsync(CurrencyExchangeCreateRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new CurrencyExchangeCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }
}