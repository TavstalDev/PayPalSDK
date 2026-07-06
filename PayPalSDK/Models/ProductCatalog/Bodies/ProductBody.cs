using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Products;

namespace Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;

/// <summary>
/// Represents the body of a product in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ProductBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the product.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(50)]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("name")]
    [StringLength(127)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(256)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the type of the product.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("type")]
    public EProductType Type { get; set; }

    /// <summary>
    /// Gets or sets the category of the product.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("category")]
    public EProductCategory? Category { get; set; }

    /// <summary>
    /// Gets or sets the URL of the product image.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("image_url")]
    [StringLength(2000)]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL of the product's homepage.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("home_url")]
    [StringLength(2000)]
    public string? HomeUrl { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}