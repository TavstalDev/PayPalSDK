using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents tax information for payments in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Taxes
{
    /// <summary>
    /// Gets or sets a value indicating whether the tax is inclusive.
    /// </summary>
    /// <remarks>
    /// This field specifies if the tax is included in the total amount.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("inclusive")]
    public bool? Inclusive { get; set; }

    /// <summary>
    /// Gets or sets the percentage of the tax.
    /// </summary>
    /// <remarks>
    /// This field must be a valid numeric value, including integers or decimals.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("percentage")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? Percentage { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}