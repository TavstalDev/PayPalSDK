using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;

/// <summary>
/// Represents the body of a product list response.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ProductListBody
{
    /// <summary>
    /// Gets or sets the list of products in the response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("products")]
    public List<ProductListElement>? Products { get; set; }

    /// <summary>
    /// Gets or sets the total number of items in the product list.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the total number of pages in the product list.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the list of links associated with the product list.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}