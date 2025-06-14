using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

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
    /// Initializes a new instance of the <see cref="Amount"/> class.
    /// </summary>
    /// <param name="currencyCode">The currency code in ISO 4217 format.</param>
    /// <param name="value">The value of the amount.</param>
    public Amount(string currencyCode, string value)
    {
        CurrencyCode = currencyCode;
        Value = value;
    }
}