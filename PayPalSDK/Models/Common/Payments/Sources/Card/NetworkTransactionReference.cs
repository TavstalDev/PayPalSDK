using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;


/// <summary>
/// Represents a network transaction reference object in the PayPal SDK.
/// </summary>
[DataContract]
public class NetworkTransactionReference
{
    /// <summary>
    /// Gets or sets the transaction reference ID returned by the scheme.
    /// <br/>For Visa and Amex, this is the "Tran id" field in the response.
    /// <br/>For MasterCard, this is the "BankNet reference id" field in the response.
    /// <br/>For Discover, this is the "NRID" field in the response.
    /// <br/>The expected pattern for this field is:
    /// <br/>- Numeric for Visa/Amex/CB/Discover.
    /// <br/>- Alphanumeric for MasterCard/BNPP.
    /// <br/>- Alphanumeric with special characters for Paysecure.
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [StringLength(36)]
    public required string Id { get; set; }

    /// <summary>
    /// Gets or sets the date the transaction was authorized by the scheme.
    /// <br/>This field may not be returned for all networks.
    /// <br/>MasterCard refers to this field as "BankNet reference date."
    /// </summary>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    [StringLength(4)]
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets the reference ID issued for the card transaction.
    /// <br/>This ID can be used to track the transaction across processors, card brands, and issuing banks.
    /// </summary>
    [DataMember(Name = "acquirer_reference_number", EmitDefaultValue = false)]
    [StringLength(36)]
    public string AcquirerReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the card network through which the transaction was routed.
    /// <br/>Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.CardNetwork"/>.
    /// </summary>
    [DataMember(Name = "network", EmitDefaultValue = false)]
    [StringLength(255)]
    public string Network { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTransactionReference"/> class.
    /// </summary>
    /// <param name="id">The transaction reference ID returned by the scheme.</param>
    /// <param name="date">The date the transaction was authorized by the scheme.</param>
    /// <param name="acquirerReferenceNumber">The reference ID issued for the card transaction.</param>
    /// <param name="network">The name of the card network through which the transaction was routed.</param>
    public NetworkTransactionReference(string id, string date, string acquirerReferenceNumber, string network)
    {
        Id = id;
        Date = date;
        AcquirerReferenceNumber = acquirerReferenceNumber;
        Network = network;
    }
}