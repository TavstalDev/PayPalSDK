using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.ProductCatalog;

/// <summary>
/// Represents a request to create a new product in the product catalog.
/// </summary>
public class ProductCreateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCreateRequest"/> class.
    /// </summary>
    /// <param name="body">The body of the product to be created, containing product details.</param>
    public ProductCreateRequest(ProductBody body)
        :
        base(HttpMethod.Post, "/v1/catalogs/products", typeof(ProductBody))
    {
        // Sets the content of the HTTP request using the provided body and JSON serialization options.
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}