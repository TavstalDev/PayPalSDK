using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PayPalStoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentInitators"/>.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("payment_initiator")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    [Required]
    public string? PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the charge pattern for the stored credentials.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("charge_pattern")]
    [StringLength(30)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? ChargePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage pattern for the stored credentials.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [StringLength(30)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? UsagePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.CredentialUsage"/>.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("usage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Usage { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}