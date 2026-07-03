using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents a person with a full name.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Person
{
    /// <summary>
    /// Gets or sets the full name of the person.
    /// </summary>
    /// <remarks>
    /// This field is optional and will not be emitted if its value is null or default.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("full_name")]
    public string? FullName { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}