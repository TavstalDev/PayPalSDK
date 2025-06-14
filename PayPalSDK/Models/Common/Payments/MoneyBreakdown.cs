using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

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
    [DataMember(Name = "currency_code", EmitDefaultValue = false)]
    [StringLength(3)]
    public required string CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the value of the amount.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 32 characters.
    /// </remarks>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    [StringLength(32)]
    public required string Value { get; set; }

    /// <summary>
    /// Gets or sets the breakdown of the amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the detailed breakdown of the monetary amount.
    /// </remarks>
    [DataMember(Name = "breakdown", EmitDefaultValue = false)]
    public Breakdown Breakdown { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MoneyBreakdown"/> class.
    /// </summary>
    /// <param name="currencyCode">The three-character ISO-4217 currency code that identifies the currency.</param>
    /// <param name="value">The value of the amount.</param>
    /// <param name="breakdown">The breakdown of the amount.</param>
    public MoneyBreakdown(string currencyCode, string value, Breakdown breakdown)
    {
        CurrencyCode = currencyCode;
        Value = value;
        Breakdown = breakdown;
    }
}