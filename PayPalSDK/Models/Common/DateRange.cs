using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a date-time range with a required start and end timestamp.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DateRange
{
    /// <summary>
    /// Gets or sets the start of the date range.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("start")]
    [StringLength(maximumLength: 64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    [Required]
    public string? Start { get; set; }
    
    /// <summary>
    /// Gets or sets the end of the date range.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("end")]
    [StringLength(maximumLength: 64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? End { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}