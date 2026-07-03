using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the exchange rate details for a payment transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ExchangeRate
{
    /// <summary>
    /// The exchange rate value as a string.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The source currency code in ISO 4217 format (3 characters).
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("source_currency")]
    [StringLength(3)]
    public string? SourceCurrency { get; set; }

    /// <summary>
    /// The target currency code in ISO 4217 format (3 characters).
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("target_currency")]
    [StringLength(3)]
    public string? TargetCurrency { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}