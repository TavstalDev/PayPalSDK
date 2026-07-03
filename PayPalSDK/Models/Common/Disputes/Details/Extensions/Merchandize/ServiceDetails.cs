using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;

/// <summary>
/// Represents the details of a service-related dispute in a PayPal transaction, including description, service start date, notes, sub-reasons, and purchase URL.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ServiceDetails
{
    /// <summary>
    /// Gets or sets the description of the service-related dispute in the PayPal transaction.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(2000)]
    public string? Description { get; set; }
    
    /// <summary>
    /// Gets or sets the date when the service was started in the PayPal transaction, in ISO 8601 format.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("service_started")]
    [StringLength(255)]
    public string? ServiceStarted { get; set; }
    
    /// <summary>
    /// Gets or sets any notes related to the service dispute in the PayPal transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("note")]
    [StringLength(2000)]
    public string? Note { get; set; }
    
    /// <summary>
    /// Gets or sets the sub-reasons associated with the service dispute in the PayPal transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("sub_reasons")]
    public List<string>? SubReasons { get; set; }
    
    /// <summary>
    /// Gets or sets the purchase URL related to the service dispute in the PayPal transaction.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("purchase_url")]
    public string? PurchaseUrl { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}