using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.PaymentResources;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

/// <summary>
/// Represents the request payload used to create a payment resource.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentResourceCreateRequestBody
{
    /// <summary>
    /// Gets or sets the integration mode used for the payment resource.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("integration_mode")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    [Required]
    public string? IntegrationMode { get; set; }
    
    /// <summary>
    /// Gets or sets the payment resource type.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("type")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? Type { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the payment resource can be reused.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("reusable")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? Reusable { get; set; }
    
    /// <summary>
    /// Gets or sets the URL to which the payer is redirected after payment completion.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("return_url")]
    [StringLength(1024)]
    [RegularExpression("^.*$")]
    public string? ReturnUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the line items associated with the payment resource.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("line_items")]
    public List<PaymentLineItem>? LineItems { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}