using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents a customer note definition attached to a payment resource.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CustomerNote
{
    /// <summary>
    /// Gets or sets a value indicating whether the note is required.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("required")]
    public bool Required { get; set; }
    
    /// <summary>
    /// Gets or sets the label shown for the customer note field.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("label")]
    [StringLength(127)]
    public string? Label { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}