using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

/// <summary>
/// Represents merchandise-related dispute extension properties.
/// </summary>
public class MerchandizeDisputeProperties
{
    /// <summary>
    /// Gets or sets the merchandise dispute issue type code.
    /// </summary>
    [JsonPropertyName("issue_type")]
    [StringLength(255)]
    public string? IssueType { get; set; }
    
    /// <summary>
    /// Gets or sets product-specific dispute details.
    /// </summary>
    [JsonPropertyName("product_details")]
    public ProductDetails? ProductDetails { get; set; }
    
    /// <summary>
    /// Gets or sets service-specific dispute details.
    /// </summary>
    [JsonPropertyName("service_details")]
    public ServiceDetails? ServiceDetails { get; set; }
    
    /// <summary>
    /// Gets or sets cancellation-related dispute details.
    /// </summary>
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the return shipping address associated with the dispute.
    /// </summary>
    [JsonPropertyName("return_shipping_address")]
    public Address? ReturnShippingAddress { get; set; }
}