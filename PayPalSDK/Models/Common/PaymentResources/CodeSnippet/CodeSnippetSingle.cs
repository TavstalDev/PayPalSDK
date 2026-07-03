using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;

/// <summary>
/// Represents a single code snippet payload containing the snippet body.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CodeSnippetSingle
{
    /// <summary>
    /// Gets or sets the body content of the code snippet.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("body")]
    [StringLength(9999)]
    public string? Body { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}