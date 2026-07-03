using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents the tax portion of a transaction amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TaxAmount
{
    /// <summary>
    /// Gets or sets the tax amount value, including currency and numeric amount details.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("tax_amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}