using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.GooglePay;

/// <summary>
/// Represents a decrypted token for Google Pay payment sources within the PayPal SDK.
/// </summary>
[DataContract]
public class GoogleDecryptedToken
{
    /// <summary>
    /// Gets or sets the unique identifier for the message.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 250 characters.
    /// </remarks>
    [DataMember(Name = "message_id", EmitDefaultValue = false)]
    [StringLength(250)]
    public string MessageId { get; set; }

    /// <summary>
    /// Gets or sets the expiration timestamp of the message.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 13 characters.
    /// </remarks>
    [DataMember(Name = "message_expiration", EmitDefaultValue = false)]
    [StringLength(13)]
    public string MessageExpiration { get; set; }

    /// <summary>
    /// Gets or sets the payment method used in the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 4 characters.
    /// </remarks>
    [DataMember(Name = "payment_method", EmitDefaultValue = false)]
    [StringLength(4)]
    public required string PaymentMethod { get; set; }

    /// <summary>
    /// Gets or sets the authentication method used for the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 50 characters.
    /// </remarks>
    [DataMember(Name = "authentication_method", EmitDefaultValue = false)]
    [StringLength(50)]
    public required string AuthenticationMethod { get; set; }

    /// <summary>
    /// Gets or sets the cryptogram associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
    [StringLength(2000)]
    public string Cryptogram { get; set; }

    /// <summary>
    /// Gets or sets the ECI (Electronic Commerce Indicator) value for the transaction.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [DataMember(Name = "eci_indicator", EmitDefaultValue = false)]
    [StringLength(256)]
    public string EciIndicator { get; set; }

    /// <summary>
    /// Gets or sets the card details associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the card used in the transaction.
    /// </remarks>
    [DataMember(Name = "card", EmitDefaultValue = false)]
    public required Models.Common.Card Card { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleDecryptedToken"/> class.
    /// </summary>
    /// <param name="messageId">The unique identifier for the message.</param>
    /// <param name="messageExpiration">The expiration timestamp of the message.</param>
    /// <param name="paymentMethod">The payment method used in the transaction.</param>
    /// <param name="authenticationMethod">The authentication method used for the transaction.</param>
    /// <param name="cryptogram">The cryptogram associated with the transaction.</param>
    /// <param name="eciIndicator">The ECI value for the transaction.</param>
    /// <param name="card">The card details associated with the transaction.</param>
    public GoogleDecryptedToken(string messageId, string messageExpiration, string paymentMethod, string authenticationMethod, string cryptogram, string eciIndicator, Models.Common.Card card)
    {
        MessageId = messageId;
        MessageExpiration = messageExpiration;
        PaymentMethod = paymentMethod;
        AuthenticationMethod = authenticationMethod;
        Cryptogram = cryptogram;
        EciIndicator = eciIndicator;
        Card = card;
    }
}