using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;

/// <summary>
/// Represents a decrypted token used in Apple Pay transactions within the PayPal SDK.
/// </summary>
[DataContract]
public class AppleDecryptedToken
{
    /// <summary>
    /// Gets or sets the device manufacturer ID associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [DataMember(Name = "device_manufacturer_id", EmitDefaultValue = false)]
    [StringLength(2000)]
    public string DeviceManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the type of payment data associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 16 characters.
    /// </remarks>
    [DataMember(Name = "payment_data_type", EmitDefaultValue = false)]
    [StringLength(16)]
    public string PaymentDataType { get; set; }

    /// <summary>
    /// Gets or sets the transaction amount associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the transaction.
    /// </remarks>
    [DataMember(Name = "transaction_amount", EmitDefaultValue = false)]
    public Money TransactionAmount { get; set; }

    /// <summary>
    /// Gets or sets the tokenized card associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the card details used in the transaction.
    /// </remarks>
    [DataMember(Name = "tokenized_card", EmitDefaultValue = false)]
    public required TokenizedCard TokenizedCard { get; set; }

    /// <summary>
    /// Gets or sets the payment data associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains additional payment-related information.
    /// </remarks>
    [DataMember(Name = "payment_data", EmitDefaultValue = false)]
    public PaymentData PaymentData { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AppleDecryptedToken"/> class.
    /// </summary>
    /// <param name="deviceManufacturerId">The device manufacturer ID associated with the decrypted token.</param>
    /// <param name="paymentDataType">The type of payment data associated with the decrypted token.</param>
    /// <param name="transactionAmount">The transaction amount associated with the decrypted token.</param>
    /// <param name="tokenizedCard">The tokenized card associated with the decrypted token.</param>
    /// <param name="paymentData">The payment data associated with the decrypted token.</param>
    public AppleDecryptedToken(string deviceManufacturerId, string paymentDataType, Money transactionAmount, TokenizedCard tokenizedCard, PaymentData paymentData)
    {
        DeviceManufacturerId = deviceManufacturerId;
        PaymentDataType = paymentDataType;
        TransactionAmount = transactionAmount;
        TokenizedCard = tokenizedCard;
        PaymentData = paymentData;
    }
}