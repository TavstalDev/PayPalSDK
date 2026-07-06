using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Card;

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
    /// This field is optional.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("amount")]
    [Required]
    public ECardVerificationMethod Method { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}