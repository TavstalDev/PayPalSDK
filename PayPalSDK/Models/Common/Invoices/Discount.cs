using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a discount applied to an invoice.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Discount
{
    /// <summary>
    /// Gets or sets the percentage value of the discount.
    /// </summary>
    /// <remarks>
    /// The percentage must match the specified regular expression pattern for numeric values.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("percent")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? Percent { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount of the discount.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}