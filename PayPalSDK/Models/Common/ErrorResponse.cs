using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents an error response returned by the PayPal API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ErrorResponse
{
    /// <summary>
    /// Gets or sets the name or error code identifier from the PayPal API.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets a list of detailed error information objects related to this error response.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("details")]
    public List<ErrorDetail>? Details { get; set; }
    
    /// <summary>
    /// Gets or sets a human-readable message describing the error.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    
    /// <summary>
    /// Gets or sets the debug identifier for this error response.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("debug_id")]
    public string? DebugId { get; set; }
    
    /// <summary>
    /// Gets or sets a collection of <see cref="Link"/> objects related to this error response.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Returns a formatted string representation of the error response.
    /// </summary>
    /// <returns>
    /// A string containing the error name, message, debug ID, and a comma-separated list of error details
    /// in the format: "Name: {name}, Message: {message}, DebugId: {debugId}, Details: [{details}]".
    /// </returns>
    public override string ToString()
    {
        return $"Name: {Name}, Message: {Message}, DebugId: {DebugId}, Details: [{string.Join(", ", Details ?? new List<ErrorDetail>())}]";
    }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}