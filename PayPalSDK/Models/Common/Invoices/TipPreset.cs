using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Invoices;

/// <summary>
/// Represents a percentage value used in invoice-related models.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TipPreset
{
    /// <summary>
    /// Gets or sets the percentage value.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("percent")]
    [StringLength(20)]
    public string? Percent { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}