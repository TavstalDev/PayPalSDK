using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

/// <summary>
/// Represents the response body returned when listing payment tokens for a customer.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentTokenListAllResponseBody
{
    /// <summary>
    /// Gets or sets the total number of payment token items available for the query.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of pages available for the current query.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of payment tokens returned for the current page.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payment_tokens")]
    public List<PaymentToken>? PaymentTokens { get; set; }
    
    /// <summary>
    /// Gets or sets HATEOAS links associated with the paginated response.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets customer information related to the returned payment tokens.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}