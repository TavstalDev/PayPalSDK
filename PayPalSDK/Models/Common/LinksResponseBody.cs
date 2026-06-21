using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a response body containing a list of links related to a PayPal resource.
/// </summary>
[DataContract]
public class LinksResponseBody
{
    /// <summary>
    /// Gets or sets the list of links related to the PayPal resource.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}