using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.ProductCatalog;

/// <summary>
/// Represents a request to retrieve the list of products from the product catalog.
/// </summary>
public class ProductListRequest : HttpRequestBase<ProductListBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListRequest"/> class.
    /// </summary>
    public ProductListRequest()
        :
        base(HttpMethod.Get, $"/v1/catalogs/products")
    {
        // No body needed for listing products
    }
}