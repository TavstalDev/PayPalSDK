using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a hyperlink object used within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Link
{
    /// <summary>
    /// Gets or sets the URL of the link.
    /// </summary>
    /// <remarks>
    /// This field is required and specifies the target URL of the link.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("href")]
    [Required]
    public string? Href { get; set; }

    /// <summary>
    /// Gets or sets the relationship of the link to the resource.
    /// </summary>
    /// <remarks>
    /// This field is required and describes the type of relationship the link has with the resource.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("rel")]
    public string? Rel { get; set; }

    /// <summary>
    /// Gets or sets the HTTP method to be used with the link.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the HTTP method (e.g., GET, POST) for the link.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("method")]
    public EHttpMethod? Method { get; set; }
    
    /// <summary>
    /// Returns a string representation of the <see cref="Link"/> instance.
    /// </summary>
    public override string ToString()
    {
        return $"Link: [Href: {Href}, Rel: {Rel}, Method: {Method}]";
    }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}