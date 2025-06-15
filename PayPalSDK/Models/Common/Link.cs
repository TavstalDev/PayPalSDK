using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a hyperlink object used within the PayPal SDK.
/// </summary>
[DataContract]
public class Link
{
    /// <summary>
    /// Gets or sets the URL of the link.
    /// </summary>
    /// <remarks>
    /// This field is required and specifies the target URL of the link.
    /// </remarks>
    [DataMember(Name = "href", EmitDefaultValue = false)]
    public required string Href { get; set; }

    /// <summary>
    /// Gets or sets the relationship of the link to the resource.
    /// </summary>
    /// <remarks>
    /// This field is required and describes the type of relationship the link has with the resource.
    /// </remarks>
    [DataMember(Name = "rel", EmitDefaultValue = false)]
    public required string Rel { get; set; }

    /// <summary>
    /// Gets or sets the HTTP method to be used with the link.
    /// </summary>
    /// <remarks>
    /// This field is required and specifies the HTTP method (e.g., GET, POST) for the link.
    /// </remarks>
    [DataMember(Name = "method", EmitDefaultValue = false)]
    public required string Method { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Link"/> class.
    /// </summary>
    /// <param name="href">The URL of the link.</param>
    /// <param name="rel">The relationship of the link to the resource.</param>
    /// <param name="method">The HTTP method to be used with the link.</param>
    public Link(string href, string rel, string method)
    {
        Href = href;
        Rel = rel;
        Method = method;
    }
}