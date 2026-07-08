using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The type of JSON Patch (RFC 6902) update operation.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EUpdateOperation>))]
public enum EUpdateOperation
{
    /// <summary>
    /// Adds a value to an object or array.
    /// </summary>
    [JsonPropertyName("add")]
    ADD = 0,
    /// <summary>
    /// Removes a value from an object or array.
    /// </summary>
    [JsonPropertyName("remove")]
    REMOVE = 1,
    /// <summary>
    /// Replaces an existing value.
    /// </summary>
    [JsonPropertyName("replace")]
    REPLACE = 2,
    /// <summary>
    /// Moves a value from one location to another.
    /// </summary>
    [JsonPropertyName("move")]
    MOVE = 3,
    /// <summary>
    /// Copies a value from one location to another.
    /// </summary>
    [JsonPropertyName("copy")]
    COPY = 4,
    /// <summary>
    /// Tests that a value is equal to an expected value.
    /// </summary>
    [JsonPropertyName("test")]
    TEST = 5
}
