using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Card;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CardStoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("payment_initiator")]
    [Required]
    public EPaymentInitator PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the type of payment.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("payment_type")]
    public EPaymentType PaymentType { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("usage")]
    public ECardUsage? Usage { get; set; }

    /// <summary>
    /// Gets or sets the reference to the previous network transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("previous_network_transaction_reference")]
    public NetworkTransactionReference? PrevNetworkTransactionReference { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}