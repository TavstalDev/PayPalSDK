using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents discount information for an invoice, expressed either as a percentage
/// or as a fixed monetary amount.
/// </summary>
public class InvoiceDiscount
{
    /// <summary>
    /// Gets or sets the discount percentage as a numeric string.
    /// </summary>
    /// <remarks>
    /// Accepted values include integers and decimal numbers, with optional negative sign,
    /// validated by the regular expression:
    /// <c>^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$</c>.
    /// </remarks>
    [JsonPropertyName("percent")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? Percent { get; set; }

    /// <summary>
    /// Gets or sets the fixed discount amount.
    /// </summary>
    /// <remarks>
    /// Serialized as <c>amount</c> in JSON and represented by the <see cref="Money"/> model.
    /// </remarks>
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
}