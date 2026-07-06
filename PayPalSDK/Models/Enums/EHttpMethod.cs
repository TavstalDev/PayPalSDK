using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// HTTP methods supported for API requests.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EHttpMethod>))]
public enum EHttpMethod
{
    /// <summary>
    /// Retrieves a resource.
    /// </summary>
    GET = 0,
    /// <summary>
    /// Creates a new resource.
    /// </summary>
    POST = 1,
    /// <summary>
    /// Replaces an existing resource.
    /// </summary>
    PUT = 2,
    /// <summary>
    /// Removes a resource.
    /// </summary>
    DELETE = 3,
    /// <summary>
    /// Retrieves the headers of a resource.
    /// </summary>
    HEAD = 4,
    /// <summary>
    /// Establishes a tunnel to a server.
    /// </summary>
    CONNECT = 5,
    /// <summary>
    /// Describes the communication options for a resource.
    /// </summary>
    OPTIONS = 6,
    /// <summary>
    /// Applies partial modifications to a resource.
    /// </summary>
    PATCH = 7
}
