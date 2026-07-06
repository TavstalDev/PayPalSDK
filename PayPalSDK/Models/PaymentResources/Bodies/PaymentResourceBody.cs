using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.PaymentResources;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.PaymentResources;

namespace Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

/// <summary>
/// Represents a PayPal payment resource, including its identifiers, lifecycle state,
/// related links, integration details, and associated line items.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentResourceBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the payment resource.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(127)]
    [RegularExpression("^[A-Z]{3}-[A-Z0-9]+$")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the public payment link associated with the resource.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("payment_link")]
    [StringLength(200)]
    public string? PaymentLink { get; set; }
    
    /// <summary>
    /// Gets or sets the HATEOAS links related to the payment resource.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets the current status of the payment resource.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EPaymentResourceStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the creation timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the last update timestamp in ISO 8601 / RFC 3339 format.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("update_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? UpdateTime { get; set; }
    
    /// <summary>
    /// Gets or sets the integration mode used for the payment resource.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("integration_mode")]
    public EPaymentResourceIntegration IntegrationMode { get; set; }
    
    /// <summary>
    /// Gets or sets the payment resource type.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("type")]
    public EPaymentResourceType Type { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the payment resource can be reused.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("reusable")]
    [StringLength(20)]
    [RegularExpression("^[A-Z0-9_]+$")]
    public string? Reusable { get; set; }
    
    /// <summary>
    /// Gets or sets the return URL used after payment completion or cancellation.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("return_url")]
    [StringLength(1024)]
    [RegularExpression("^.*$")]
    public string? ReturnUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of line items associated with the payment resource.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("line_items")]
    public List<PaymentLineItem>? LineItems { get; set; }
    
    /// <summary>
    /// Gets or sets code snippets that help integrate or render the payment resource.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("code_snippets")]
    public PaymentCodeSnippet? CodeSnippets { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(12, "Build")]
    public void Build() { }
}