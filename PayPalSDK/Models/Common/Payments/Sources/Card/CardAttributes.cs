using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents the attributes of a card payment source in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CardAttributes
{
    /// <summary>
    /// Gets or sets the customer details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the customer information.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }

    /// <summary>
    /// Gets or sets the vault details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the vault information.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("vault")]
    public Vault? Vault { get; set; }

    /// <summary>
    /// Gets or sets the verification details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the verification information.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("verification")]
    public Verification? Verification { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}