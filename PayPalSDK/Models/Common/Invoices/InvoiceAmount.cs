using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Invoices.Breakdown;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents an invoice amount, including currency, total value,
/// and optional amount breakdown details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceAmount
{
    /// <summary>
    /// Gets or sets the three-letter ISO-4217 currency code for the invoice amount.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>currency_code</c>. Maximum length is 3 characters.
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
    /// Serialized as <c>value</c>. Maximum length is 32 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("value")]
    [StringLength(32)]
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the detailed breakdown of the invoice amount,
    /// such as item totals and discounts.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>breakdown</c>.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("breakdown")]
    public InvoiceBreakdown? Breakdown { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}