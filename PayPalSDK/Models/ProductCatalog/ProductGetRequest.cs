using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.ProductCatalog;

/// <summary>
/// Represents a request to retrieve a specific product from the product catalog.
/// </summary>
public class ProductGetRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductGetRequest"/> class.
    /// </summary>
    /// <param name="productId">The unique identifier of the product to retrieve.</param>
    public ProductGetRequest(string productId)
        :
        base(HttpMethod.Get, $"/v1/catalogs/products/{productId}", typeof(ProductBody))
    {
        // No body is needed for this GET request
    }
}