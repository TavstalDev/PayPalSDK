using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a monetary breakdown in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class MoneyBreakdown
{
    /// <summary>
    /// Gets or sets the three-character ISO-4217 currency code that identifies the currency.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 3 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("currency_code")]
    [StringLength(3)]
    [Required]
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the value of the amount.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 32 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("value")]
    [StringLength(32)]
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the breakdown of the amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the detailed breakdown of the monetary amount.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("breakdown")]
    public Breakdown? Breakdown { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}