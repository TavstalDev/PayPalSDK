using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents shipping-related information for a transaction, including
/// recipient details, shipping method, and primary/secondary addresses.
/// </summary>
public class TransactionShippingInfo
{
    /// <summary>
    /// Gets or sets the shipping recipient name.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(500)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping method or service level used for delivery.
    /// </summary>
    [JsonPropertyName("method")]
    [StringLength(500)]
    public string? Method { get; set; }
    
    /// <summary>
    /// Gets or sets the primary shipping address.
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    /// <summary>
    /// Gets or sets an alternate or secondary shipping address, when provided.
    /// </summary>
    [JsonPropertyName("secondary_shipping_address")]
    public Address? SecondaryShippingAddress { get; set; }
}