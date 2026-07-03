using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a monetary value with a currency code.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Money
{
    /// <summary>
    /// Gets or sets the currency code in ISO 4217 format.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 3 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("currency_code")]
    [StringLength(3)]
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the monetary value as a string.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 32 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("value")]
    [StringLength(32)]
    public string? Value { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}