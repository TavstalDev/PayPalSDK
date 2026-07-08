using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Card;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PayPalStoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("payment_initiator")]
    [Required]
    public EPaymentInitiator PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the charge pattern for the stored credentials.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("charge_pattern")]
    [Obsolete("This property is deprecated and may be removed in future versions.")]
    public EChargePattern? ChargePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage pattern for the stored credentials.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("usage_pattern")]
    public EChargePattern? UsagePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("usage")]
    public ECardUsage? Usage { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}