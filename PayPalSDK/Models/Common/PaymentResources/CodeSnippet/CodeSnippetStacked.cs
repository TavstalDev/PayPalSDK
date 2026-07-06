using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.PaymentTokens;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;

/// <summary>
/// Represents a stacked code snippet configuration used to render payment-related content.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CodeSnippetStacked
{
    /// <summary>
    /// Gets or sets the framework name associated with the snippet.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("framework")]
    [Required]
    public ECodeSnippetFramework Framework { get; set; }
    
    /// <summary>
    /// Gets or sets the HTML or script content placed in the page head.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("head")]
    [StringLength(9999)]
    public string? Head { get; set; }
    
    /// <summary>
    /// Gets or sets the main body content of the snippet.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("body")]
    [StringLength(9999)]
    public string? Body { get; set; }
    
    /// <summary>
    /// Gets or sets the placement configuration for payment buttons.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("button_placement")]
    [StringLength(9999)]
    public string? ButtonPlacement { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}