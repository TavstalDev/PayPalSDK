using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[DataContract]
public class StoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentInitators"/>.
    /// </summary>
    [DataMember(Name = "payment_initiator", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public required string PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the type of payment.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentType"/>.
    /// </summary>
    [DataMember(Name = "payment_type", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public required string PaymentType { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.CredentialUsage"/>.
    /// </summary>
    [DataMember(Name = "usage", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string Usage { get; set; }

    /// <summary>
    /// Gets or sets the reference to the previous network transaction.
    /// </summary>
    [DataMember(Name = "previous_network_transaction_reference", EmitDefaultValue = false)]
    public NetworkTransactionReference PrevNetworkTransactionReference { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="StoredCredentials"/> class.
    /// </summary>
    /// <param name="paymentInitiator">The payment initiator.</param>
    /// <param name="paymentType">The type of payment.</param>
    /// <param name="usage">The usage of the credential.</param>
    /// <param name="prevNetworkTransactionReference">The reference to the previous network transaction.</param>
    public StoredCredentials(string paymentInitiator, string paymentType, string usage, NetworkTransactionReference prevNetworkTransactionReference)
    {
        PaymentInitiator = paymentInitiator;
        PaymentType = paymentType;
        Usage = usage;
        PrevNetworkTransactionReference = prevNetworkTransactionReference;
    }
}