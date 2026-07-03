using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

/// <summary>
/// Represents merchandise-related dispute extension properties.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class MerchandizeDisputeProperties
{
    /// <summary>
    /// Gets or sets the merchandise dispute issue type code.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("issue_type")]
    [StringLength(255)]
    public string? IssueType { get; set; }
    
    /// <summary>
    /// Gets or sets product-specific dispute details.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("product_details")]
    public ProductDetails? ProductDetails { get; set; }
    
    /// <summary>
    /// Gets or sets service-specific dispute details.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("service_details")]
    public ServiceDetails? ServiceDetails { get; set; }
    
    /// <summary>
    /// Gets or sets cancellation-related dispute details.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address associated with the dispute.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}