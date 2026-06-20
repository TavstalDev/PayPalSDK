using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;

/// <summary>
/// Represents a stacked code snippet configuration used to render payment-related content.
/// </summary>
[DataContract]
public class CodeSnippetStacked
{
    /// <summary>
    /// Gets or sets the framework name associated with the snippet.
    /// </summary>
    [JsonPropertyName("framework")]
    [StringLength(32)]
    public required string Framework { get; set; }
    
    /// <summary>
    /// Gets or sets the HTML or script content placed in the page head.
    /// </summary>
    [JsonPropertyName("head")]
    [StringLength(9999)]
    public string? Head { get; set; }
    
    /// <summary>
    /// Gets or sets the main body content of the snippet.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(9999)]
    public string? Body { get; set; }
    
    /// <summary>
    /// Gets or sets the placement configuration for payment buttons.
    /// </summary>
    [JsonPropertyName("button_placement")]
    [StringLength(9999)]
    public string? ButtonPlacement { get; set; }
}