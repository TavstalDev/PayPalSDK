using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents an amount with a currency code and value.
/// </summary>
[DataContract]
public class Amount
{
    /// <summary>
    /// Gets or sets the currency code in ISO 4217 format.
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
}