using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.PaymentResources;

namespace Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

/// <summary>
/// Represents the request payload used to replace an existing payment resource.
/// </summary>
[DataContract]
public class PaymentResourceReplaceRequestBody
{
    /// <summary>
    /// Gets or sets the integration mode used for the payment resource.
    /// </summary>
    [JsonPropertyName("integration_mode")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public required string IntegrationMode { get; set; }
    
    /// <summary>
    /// Gets or sets the payment resource type.
    /// </summary>
    [JsonPropertyName("type")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public required string Type { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the payment resource can be reused.
    /// </summary>
    [JsonPropertyName("reusable")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? Reusable { get; set; }
    
    /// <summary>
    /// Gets or sets the URL to which the payer is redirected after payment processing.
    /// </summary>
    [JsonPropertyName("return_url")]
    [StringLength(1024)]
    [RegularExpression("^.*$")]
    public string? ReturnUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of line items that define the replacement payment resource.
    /// </summary>
    [JsonPropertyName("line_items")]
    public List<PaymentLineItem>? LineItems { get; set; }
}