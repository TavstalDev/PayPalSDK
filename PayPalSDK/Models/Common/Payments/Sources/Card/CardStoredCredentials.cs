using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CardStoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentInitators"/>.
    /// </summary>
    [FluentMember(0)]
    [JsonPropertyName("payment_initiator")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    [Required]
    public string? PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the type of payment.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentType"/>.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("payment_type")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? PaymentType { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.CredentialUsage"/>.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("usage")]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string? Usage { get; set; }

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