using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a name object used in PayPal SDK models.
/// </summary>
public class NameObj
{
    /// <summary>
    /// Gets or sets the name value. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }
}