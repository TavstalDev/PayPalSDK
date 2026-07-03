using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents the attributes of a card payment source in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SourceAttributes
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
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}