using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a range of monetary values with lower and upper bounds.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class MoneyRange
{
    /// <summary>
    /// Gets or sets the lower bound of the monetary range.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("lower_amount")]
    [Required]
    public Money? LowerAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the upper bound of the monetary range.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("upper_amount")]
    public Money? UpperAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}