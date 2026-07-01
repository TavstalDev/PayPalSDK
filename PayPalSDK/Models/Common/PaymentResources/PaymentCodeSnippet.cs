using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.PaymentResources.CodeSnippet;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources;

/// <summary>
/// Represents payment code snippet variants for different display modes.
/// </summary>
public class PaymentCodeSnippet
{
    /// <summary>
    /// Gets or sets the single-layout code snippet configuration.
    /// </summary>
    [JsonPropertyName("single")]
    public CodeSnippetSingle? Single { get; set; }
    
    /// <summary>
    /// Gets or sets the stacked-layout code snippet configurations.
    /// </summary>
    [JsonPropertyName("stacked")]
    public List<CodeSnippetStacked>? Stacked { get; set; }
}