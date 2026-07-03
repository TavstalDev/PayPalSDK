using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents a verification object in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Verification
{
    /// <summary>
    /// Gets or sets the card verification method.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 255 characters, and should correspond to one of the constants defined in <see cref="Tavstal.PayPalSDK.Constants.CardVerificationMethods"/>.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    [StringLength(255)]
    public string? Method { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}