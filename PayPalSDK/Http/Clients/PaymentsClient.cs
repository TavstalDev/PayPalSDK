using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for capturing, refunding, authorizing, and managing payment transactions.
/// </summary>
public class PaymentsClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentsClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public PaymentsClient(PayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Captures payment for an authorization.
    /// </summary>
    /// <param name="id">The authorization identifier.</param>
    /// <param name="body">The capture request payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="CapturedPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<CapturedPaymentBody, ErrorResponse>> CaptureAsync(string id, PaymentCaptureRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentCaptureRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Refunds a captured payment.
    /// </summary>
    /// <param name="id">The capture or payment identifier to refund.</param>
    /// <param name="body">The refund request payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="RefundPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<RefundPaymentBody, ErrorResponse>> RefundPaymentAsync(string id,
        PaymentRefundRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new PaymentRefundRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves details of an authorized payment.
    /// </summary>
    /// <param name="id">The authorization identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="AuthorizedPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<AuthorizedPaymentBody, ErrorResponse>> GetAuthorizedAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentGetAuthorizedDetailsRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }
    
    /// <summary>
    /// Retrieves details of a captured payment.
    /// </summary>
    /// <param name="id">The capture identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="CapturedPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<CapturedPaymentBody, ErrorResponse>> GetCapturedAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentGetCapturedDetailsRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves details of a refund.
    /// </summary>
    /// <param name="id">The refund identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="RefundPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<RefundPaymentBody, ErrorResponse>> GetRefundAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentGetRefundDetailsRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Voids an authorization, preventing any future captures.
    /// </summary>
    /// <param name="id">The authorization identifier to void.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="AuthorizedPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<AuthorizedPaymentBody, ErrorResponse>> VoidAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentVoidRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Reauthorizes a payment to extend its validity.
    /// </summary>
    /// <param name="id">The authorization identifier to reauthorize.</param>
    /// <param name="body">The reauthorization request payload.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="CapturedPaymentBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<CapturedPaymentBody, ErrorResponse>> ReauthorizeAsync(string id, PaymentReauthorizeRequestBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new PaymentReauthorizeRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Finds eligible payment methods based on transaction criteria.
    /// </summary>
    /// <param name="body">The request payload containing eligibility filters.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="EligibleMethodResponse"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<EligibleMethodResponse, ErrorResponse>> FindEligibleAsync(
        PaymentFindEligibleMethodsRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new PaymentFindEligibleMethodsRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }
}