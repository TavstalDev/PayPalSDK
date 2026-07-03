using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents shipping-related information for a transaction, including
/// recipient details, shipping method, and primary/secondary addresses.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionShippingInfo
{
    /// <summary>
    /// Gets or sets the shipping recipient name.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(500)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping method or service level used for delivery.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("method")]
    [StringLength(500)]
    public string? Method { get; set; }
    
    /// <summary>
    /// Gets or sets the primary shipping address.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    /// <summary>
    /// Gets or sets an alternate or secondary shipping address, when provided.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("secondary_shipping_address")]
    public Address? SecondaryShippingAddress { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}