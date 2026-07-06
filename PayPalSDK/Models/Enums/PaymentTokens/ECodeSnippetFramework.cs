using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.PaymentTokens;

/// <summary>
/// The code snippet framework type for payment token components.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECodeSnippetFramework>))]
public enum ECodeSnippetFramework
{
    /// <summary>HTML framework.</summary>
    HTML = 0,
    /// <summary>React framework.</summary>
    REACT = 1
}
