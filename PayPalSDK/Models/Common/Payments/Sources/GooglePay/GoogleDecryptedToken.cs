using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.GooglePay;

/// <summary>
/// Represents a decrypted token for Google Pay payment sources within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class GoogleDecryptedToken
{
    /// <summary>
    /// Gets or sets the unique identifier for the message.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 250 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("message_id")]
    [StringLength(250)]
    public string? MessageId { get; set; }

    /// <summary>
    /// Gets or sets the expiration timestamp of the message.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 13 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("message_expiration")]
    [StringLength(13)]
    public string? MessageExpiration { get; set; }

    /// <summary>
    /// Gets or sets the payment method used in the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("payment_method")]
    public EGooglePaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or sets the authentication method used for the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("authentication_method")]
    public EGoogleAuthenticationMethod AuthenticationMethod { get; set; }

    /// <summary>
    /// Gets or sets the cryptogram associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("cryptogram")]
    [StringLength(2000)]
    public string? Cryptogram { get; set; }

    /// <summary>
    /// Gets or sets the ECI (Electronic Commerce Indicator) value for the transaction.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("eci_indicator")]
    [StringLength(256)]
    public string? EciIndicator { get; set; }

    /// <summary>
    /// Gets or sets the card details associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the card used in the transaction.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("card")]
    public Models.Common.Card? Card { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}