using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents an update operation for modifying resources in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class UpdateOperation
{
    /// <summary>
    /// Gets or sets the type of operation to be performed.
    /// </summary>
    /// <remarks>
    /// Examples include "add", "remove", "replace", etc.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("op")]
    [Required]
    public string? Op { get; set; }

    /// <summary>
    /// Gets or sets the JSON Pointer path to the target field.
    /// </summary>
    /// <remarks>
    /// Specifies the location in the resource where the operation is applied.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Gets or sets the value to be used in the operation.
    /// </summary>
    /// <remarks>
    /// This field is optional and depends on the type of operation being performed.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// Gets or sets the source path for a "move" operation.
    /// </summary>
    /// <remarks>
    /// This field is optional and is used only for "move" operations to specify the source location.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}