using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents payment code snippet variants for different display modes.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentCodeSnippet
{
    /// <summary>
    /// Gets or sets the single-layout code snippet configuration.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("single")]
    public CodeSnippetSingle? Single { get; set; }
    
    /// <summary>
    /// Gets or sets the stacked-layout code snippet configurations.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("stacked")]
    public List<CodeSnippetStacked>? Stacked { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}