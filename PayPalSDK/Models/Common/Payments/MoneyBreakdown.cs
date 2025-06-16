using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a monetary breakdown in the PayPal SDK.
/// </summary>
[DataContract]
public class MoneyBreakdown
{
    /// <summary>
    /// Gets or sets the three-character ISO-4217 currency code that identifies the currency.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 3 characters.
    /// </remarks>
    [JsonPropertyName("currency_code")]
    [StringLength(3)]
    public required string CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the value of the amount.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 32 characters.
    /// </remarks>
    [JsonPropertyName("value")]
    [StringLength(32)]
    public required string Value { get; set; }

    /// <summary>
    /// Gets or sets the breakdown of the amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the detailed breakdown of the monetary amount.
    /// </remarks>
    [JsonPropertyName("breakdown")]
    public required Breakdown Breakdown { get; set; }
}