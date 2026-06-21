using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;

namespace Tavstal.PayPalSDK.Models.ProductCatalog;

/// <summary>
/// Represents a request to retrieve the list of products from the product catalog.
/// </summary>
public class ProductListRequest : HttpRequestBase<ProductListBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListRequest"/> class.
    /// </summary>
    /// <param name="pageSize">The number of products to retrieve per page. Default is 10.</param>
    /// <param name="page">The page number to retrieve. Default is 1.</param>
    /// <param name="totalRequired">Indicates whether the total count of products is required. Default is false.</param>
    public ProductListRequest(int pageSize = 10, int page = 1, bool totalRequired = false)
        : base(
            HttpMethod.Get,
            $"/v1/catalogs/products?page_size={pageSize}&page={page}&total_required={totalRequired}"
        )
    {
        // No body needed for listing products
    }
}