using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a seller or merchant entity involved in a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Seller
{
    /// <summary>
    /// Gets or sets the unique merchant identifier for the seller.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("merchant_id")]
    [StringLength(255)]
    public string? MerchantId { get; set; }
    
    /// <summary>
    /// Gets or sets the display name of the seller.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the email address of the seller.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("email")]
    [StringLength(254, MinimumLength = 3)]
    [RegularExpression("^(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])$")]
    public string? Email { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}