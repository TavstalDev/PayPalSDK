using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes;

/// <summary>
/// Represents an evidence document used in PayPal dispute models.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EvidenceDocument
{
    /// <summary>
    /// Gets or sets the name of the evidence document. This property can be null and has a maximum length of 2000 characters.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the URL of the evidence document. This property can be null and represents the location of the document.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}