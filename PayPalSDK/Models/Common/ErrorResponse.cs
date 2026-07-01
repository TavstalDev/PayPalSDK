using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents an error response returned by the PayPal API.
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// Gets or sets the name or error code identifier from the PayPal API.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets a list of detailed error information objects related to this error response.
    /// </summary>
    [JsonPropertyName("details")]
    public List<ErrorDetail>? Details { get; set; }
    
    /// <summary>
    /// Gets or sets a human-readable message describing the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    
    /// <summary>
    /// Gets or sets the debug identifier for this error response.
    /// </summary>
    [JsonPropertyName("debug_id")]
    public string? DebugId { get; set; }
    
    /// <summary>
    /// Gets or sets a collection of <see cref="Link"/> objects related to this error response.
    /// </summary>
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
}