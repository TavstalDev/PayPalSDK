using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;

/// <summary>
/// Represents a decrypted token used in Apple Pay transactions within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class AppleDecryptedToken
{
    /// <summary>
    /// Gets or sets the device manufacturer ID associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("device_manufacturer_id")]
    [StringLength(2000)]
    public string? DeviceManufacturerId { get; set; }

    /// <summary>
    /// Gets or sets the type of payment data associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payment_data_type")]
    public EPaymentDataType? PaymentDataType { get; set; }

    /// <summary>
    /// Gets or sets the transaction amount associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the transaction.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("transaction_amount")]
    public Money? TransactionAmount { get; set; }

    /// <summary>
    /// Gets or sets the tokenized card associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the card details used in the transaction.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("tokenized_card")]
    public TokenizedCard? TokenizedCard { get; set; }

    /// <summary>
    /// Gets or sets the payment data associated with the decrypted token.
    /// </summary>
    /// <remarks>
    /// This field is optional and contains additional payment-related information.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("payment_data")]
    public PaymentData? PaymentData { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}