using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents tax information for a payment.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Tax
{
    /// <summary>
    /// Gets or sets the name of the tax.
    /// </summary>
    /// <remarks>
    /// The name must not exceed 100 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("name")]
    [StringLength(100)]
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets additional notes about the tax.
    /// </summary>
    /// <remarks>
    /// The tax note must not exceed 40 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("tax_note")]
    [StringLength(40)]
    public string? TaxNote { get; set; }

    /// <summary>
    /// Gets or sets the percentage value of the tax.
    /// </summary>
    /// <remarks>
    /// The percentage must match the specified regular expression pattern for numeric values.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("percent")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? Percent { get; set; }
    
    /// <summary>
    /// Gets or sets the amount of tax applied to the payment.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}