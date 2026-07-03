using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a name object used in PayPal SDK models.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class NameObj
{
    /// <summary>
    /// Gets or sets the name value. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}