using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.ProductCatalog;
using Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;

namespace Tavstal.PayPalSDK.Http.Clients;

/// <summary>
/// Provides operations for creating, retrieving, listing, and updating products in the catalog.
/// </summary>
public sealed class ProductCatalogClient : ClientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCatalogClient"/> class.
    /// </summary>
    /// <param name="client">The shared PayPal HTTP client used to send requests.</param>
    public ProductCatalogClient(IPayPalHttpClient client) : base(client) { }

    /// <summary>
    /// Creates a new product in the catalog.
    /// </summary>
    /// <param name="body">The product payload containing catalog details.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the created <see cref="ProductBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<ProductBody, ErrorResponse>> CreateAsync(ProductBody body,
        CancellationToken cancellationToken = default)
    {
        var request = new ProductCreateRequest(body);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Retrieves a product from the catalog by identifier.
    /// </summary>
    /// <param name="id">The product identifier.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing the requested <see cref="ProductBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<ProductBody, ErrorResponse>> GetAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var request = new ProductGetRequest(id);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Lists products in the catalog with optional paging controls.
    /// </summary>
    /// <param name="pageSize">The number of products to return per page.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="totalRequired">Whether to include total count metadata in the response.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see cref="ProductListBody"/> on success,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<ProductListBody, ErrorResponse>> ListAsync(int pageSize = 10, int page = 1, bool totalRequired = false, 
        CancellationToken cancellationToken = default)
    {
        var request = new ProductListRequest(pageSize, page, totalRequired);
        return await ExecuteAsync(request, cancellationToken);
    }

    /// <summary>
    /// Updates an existing product using patch operations.
    /// </summary>
    /// <param name="id">The product identifier.</param>
    /// <param name="body">A list of patch operations describing updates to apply.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// A result containing <see langword="true"/> if the update succeeds,
    /// or an <see cref="ErrorResponse"/> on failure.
    /// </returns>
    public async Task<Result<bool, ErrorResponse>> UpdateAsync(string id, List<UpdateOperation> body, CancellationToken cancellationToken = default)
    {
        var request = new ProductUpdateRequest(id, body);
        return await ExecuteAsync(request, cancellationToken);
    }
}