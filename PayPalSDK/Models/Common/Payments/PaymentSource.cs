using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a payment source in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentSource
{
    /// <summary>
    /// Gets or sets the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using a card.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("card")]
    public CardSource? CardSource { get; set; }

    /// <summary>
    /// Gets or sets the token payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using a token.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("token")]
    public TokenSource? Token { get; set; }

    /// <summary>
    /// Gets or sets the PayPal payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using PayPal.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("paypal")]
    public PayPalSource? PayPal { get; set; }

    /// <summary>
    /// Gets or sets the Bancontact payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Bancontact.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("bancontact")]
    public BanContactSource? BanContact { get; set; }

    /// <summary>
    /// Gets or sets the Blik payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Blik.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("blik")]
    public BlikSource? Blik { get; set; }

    /// <summary>
    /// Gets or sets the EPS payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using EPS.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("eps")]
    public EpsSource? Eps { get; set; }

    /// <summary>
    /// Gets or sets the GiroPay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using GiroPay.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("giropay")]
    public GiroPaySource? GiroPay { get; set; }

    /// <summary>
    /// Gets or sets the iDEAL payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using iDEAL.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("ideal")]
    public IdealSource? Ideal { get; set; }

    /// <summary>
    /// Gets or sets the MyBank payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using MyBank.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("mybank")]
    public MyBankSource? MyBank { get; set; }

    /// <summary>
    /// Gets or sets the P24 payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using P24.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("p24")]
    public PTwentyFourSource? PTwentyFour { get; set; }

    /// <summary>
    /// Gets or sets the Sofort payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Sofort.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("sofort")]
    public SofortSource? Sofort { get; set; }

    /// <summary>
    /// Gets or sets the Trustuly payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Trustuly.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("trustuly")]
    public TrustulySource? Trustuly { get; set; }

    /// <summary>
    /// Gets or sets the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Apple Pay.
    /// </remarks>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("apple_pay")]
    public ApplePaySource? ApplePay { get; set; }
    
    /// <summary>
    /// Gets or sets the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Google Pay.
    /// </remarks>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("google_pay")]
    public GooglePaySource? GooglePay { get; set; }

    /// <summary>
    /// Gets or sets the Venmo payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Venmo.
    /// </remarks>
    [FluentMember(14)]
    [FluentSkippable]
    [JsonPropertyName("venmo")]
    public VenmoSource? Venmo { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(15, "Build")]
    public void Build() { }
}