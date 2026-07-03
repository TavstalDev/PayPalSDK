using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents a subscriber's card information used for billing purposes.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriberCard
{
    /// <summary>
    /// Gets or sets the name on the card.
    /// </summary>
    /// <remarks>
    /// The name can have a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(300)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the card number.
    /// </summary>
    /// <remarks>
    /// The card number is required and can have a maximum length of 19 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("number")]
    [StringLength(19)]
    public string? Number { get; set; }

    /// <summary>
    /// Gets or sets the security code of the card.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("security_code")]
    public string? SecurityCode { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the card.
    /// </summary>
    /// <remarks>
    /// The expiry date is required and must follow the format "YYYY-MM" (e.g., 2023-09).
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("expiry")]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public string? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the billing address associated with the card.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}