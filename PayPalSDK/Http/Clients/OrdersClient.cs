using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating, retrieving, updating, and progressing PayPal orders.
/// </summary>
public class OrdersClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public OrdersClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a new order.
    /// </summary>
    /// <param name="body">The payload describing purchase units, payer context, and payment intent.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the created <see cref="OrderBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> CreateAsync(OrderCreateRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new OrderCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }
    
    /// <summary>
    /// Retrieves details for an existing order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the current <see cref="OrderBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> GetAsync(string orderId, CancellationToken cancellationToken = default)
    {
        var request = new OrderGetDetailsRequest(orderId);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Authorizes payment for an order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="body">Optional authorization details for the request.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the updated <see cref="OrderBody"/> after authorization on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> AuthorizeAsync(string orderId, OrderAuthorizeRequestBody? body = null,
        CancellationToken cancellationToken = default)
    {
        var request = new OrderAuthorizeRequest(orderId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Captures payment for an order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="body">Optional capture details for the request.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the updated <see cref="OrderBody"/> after capture on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> CaptureAsync(string orderId, OrderCaptureRequestBody? body = null,
        CancellationToken cancellationToken = default)
    {
        var request = new OrderCaptureRequest(orderId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Applies patch operations to an existing order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="body">A list of patch operations describing updates to apply.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> if the update succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateAsync(string orderId, List<UpdateOperation> body, CancellationToken cancellationToken = default)
    {
        var request = new OrderUpdateRequest(orderId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Confirms an order before payer approval or payment completion.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="body">The confirmation payload.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the updated <see cref="OrderBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> ConfirmAsync(string orderId,
        OrderConfirmRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new OrderConfirmRequest(orderId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Adds tracking information to an order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="body">The tracking payload containing carrier and tracking details.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing the updated <see cref="OrderBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<OrderBody, ErrorResponse>> AddTrackingAsync(string orderId, OrderTrackingRequestBody body, CancellationToken cancellationToken = default)
    {
        var request = new OrderAddTrackingRequest(orderId, body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates existing tracking information for an order.
    /// </summary>
    /// <param name="orderId">The PayPal order identifier.</param>
    /// <param name="trackerId">The tracker identifier associated with the order shipment.</param>
    /// <param name="body">A list of patch operations describing tracking updates.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> if the tracking update succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateTrackingAsync(string orderId, string trackerId,
        List<UpdateOperation> body, CancellationToken cancellationToken = default)
    {
        var request = new OrderUpdateTrackingRequest(orderId, trackerId, body);
        return await ExecuteAsync(request, cancellationToken);
    }
}