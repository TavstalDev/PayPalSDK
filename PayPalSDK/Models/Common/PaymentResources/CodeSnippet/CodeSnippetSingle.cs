using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;

/// <summary>
/// Represents a single code snippet payload containing the snippet body.
/// </summary>
public class CodeSnippetSingle
{
    /// <summary>
    /// Gets or sets the body content of the code snippet.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(9999)]
    public string? Body { get; set; }
}