using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents an evidence document used in PayPal dispute models.
/// </summary>
public class EvidenceDocument
{
    /// <summary>
    /// Gets or sets the name of the evidence document. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the URL of the evidence document. This property can be null and represents the location of the document.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}