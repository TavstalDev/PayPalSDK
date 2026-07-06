using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Card;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a card used in transactions within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Card
{
    /// <summary>
    /// Gets or sets the name associated with the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(300)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the card number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 19 characters.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("number")]
    [StringLength(19)]
    public string? Number { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the card.
    /// </summary>
    /// <remarks>
    /// This field is required and must match the format YYYY-MM, where YYYY is the year and MM is the month.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("expiry")]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public string? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the type of the card.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("type")]
    public ECardType? Type { get; set; }

    /// <summary>
    /// Gets or sets the brand of the card.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("brand")]
    public ECardBrand? Brand { get; set; }

    /// <summary>
    /// Gets or sets the billing address associated with the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the billing address details.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}