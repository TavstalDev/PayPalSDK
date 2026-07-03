using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a platform fee in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PlatformFee
{
    /// <summary>
    /// Gets or sets the payee associated with the platform fee.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient of the platform fee.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("payee")]
    public Payee? Payee { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount of the platform fee.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the amount to be charged as a platform fee.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}