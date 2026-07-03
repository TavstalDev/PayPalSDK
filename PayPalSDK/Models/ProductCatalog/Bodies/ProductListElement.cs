using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;

/// <summary>
/// Represents an element in the product list.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ProductListElement
{
    /// <summary>
    /// Gets or sets the unique identifier of the product.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(50)]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(127)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(256)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the list of links associated with the product.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the product.
    /// The format must follow the ISO 8601 standard.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("created_time")]
    [StringLength(64)]
    [RegularExpression(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreatedTime { get; set; }
    
    /// <summary>
    /// Gets the creation time of the product as a nullable DateTime object.
    /// </summary>
    public DateTime? CreatedTimeAsDateTime => DateTimeHelper.FromISO8601(CreatedTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}