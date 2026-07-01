using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents the tax portion of a transaction amount.
/// </summary>
public class TaxAmount
{
    /// <summary>
    /// Gets or sets the tax amount value, including currency and numeric amount details.
    /// </summary>
    [JsonPropertyName("tax_amount")]
    public Money? Amount { get; set; }
}