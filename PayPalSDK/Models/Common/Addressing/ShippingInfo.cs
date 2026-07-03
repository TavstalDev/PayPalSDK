using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents shipping information for a transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ShippingInfo
{
    /// <summary>
    /// Gets or sets the business name associated with the shipping information.
    /// </summary>
    /// <remarks>
    /// The business name must not exceed 300 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("business_name")]
    [StringLength(300)]
    public string? BusinessName { get; set; }

    /// <summary>
    /// Gets or sets the name information of the recipient.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    public NameInfo? Name { get; set; }

    /// <summary>
    /// Gets or sets the address information for shipping.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}