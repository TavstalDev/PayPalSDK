using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources;

namespace Tavstal.PayPalSDK.Models.Common.Payments;


/// <summary>
/// Represents a payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class PaymentSource
{
    /// <summary>
    /// Gets or sets the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using a card.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public CardSource CardSource { get; set; }

    /// <summary>
    /// Gets or sets the token payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using a token.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public TokenSource Token { get; set; }

    /// <summary>
    /// Gets or sets the PayPal payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using PayPal.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public PayPalSource PayPal { get; set; }

    /// <summary>
    /// Gets or sets the Bancontact payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Bancontact.
    /// </remarks>
    [DataMember(Name = "bancontact", EmitDefaultValue = false)]
    public BanContactSource BanContact { get; set; }

    /// <summary>
    /// Gets or sets the Blik payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Blik.
    /// </remarks>
    [DataMember(Name = "blik", EmitDefaultValue = false)]
    public BlikSource Blik { get; set; }

    /// <summary>
    /// Gets or sets the EPS payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using EPS.
    /// </remarks>
    [DataMember(Name = "eps", EmitDefaultValue = false)]
    public EpsSource Eps { get; set; }

    /// <summary>
    /// Gets or sets the GiroPay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using GiroPay.
    /// </remarks>
    [DataMember(Name = "giropay", EmitDefaultValue = false)]
    public GiroPaySource GiroPay { get; set; }

    /// <summary>
    /// Gets or sets the iDEAL payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using iDEAL.
    /// </remarks>
    [DataMember(Name = "ideal", EmitDefaultValue = false)]
    public IdealSource Ideal { get; set; }

    /// <summary>
    /// Gets or sets the MyBank payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using MyBank.
    /// </remarks>
    [DataMember(Name = "mybank", EmitDefaultValue = false)]
    public MyBankSource MyBank { get; set; }

    /// <summary>
    /// Gets or sets the P24 payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using P24.
    /// </remarks>
    [DataMember(Name = "p24", EmitDefaultValue = false)]
    public PTwentyFourSource PTwentyFour { get; set; }

    /// <summary>
    /// Gets or sets the Sofort payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Sofort.
    /// </remarks>
    [DataMember(Name = "sofort", EmitDefaultValue = false)]
    public SofortSource Sofort { get; set; }

    /// <summary>
    /// Gets or sets the Trustuly payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Trustuly.
    /// </remarks>
    [DataMember(Name = "trustuly", EmitDefaultValue = false)]
    public TrustulySource Trustuly { get; set; }

    /// <summary>
    /// Gets or sets the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Apple Pay.
    /// </remarks>
    [DataMember(Name = "apple_pay", EmitDefaultValue = false)]
    public ApplePaySource ApplePay { get; set; }
    
    /// <summary>
    /// Gets or sets the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Google Pay.
    /// </remarks>
    [DataMember(Name = "google_pay", EmitDefaultValue = false)]
    public GooglePaySource GooglePay { get; set; }

    /// <summary>
    /// Gets or sets the Venmo payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents payment details using Venmo.
    /// </remarks>
    [DataMember(Name = "venmo", EmitDefaultValue = false)]
    public VenmoSource Venmo { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentSource"/> class.
    /// </summary>
    /// <param name="cardSource">The card payment source.</param>
    /// <param name="token">The token payment source.</param>
    /// <param name="payPal">The PayPal payment source.</param>
    /// <param name="banContact">The Bancontact payment source.</param>
    /// <param name="blik">The Blik payment source.</param>
    /// <param name="eps">The EPS payment source.</param>
    /// <param name="giroPay">The GiroPay payment source.</param>
    /// <param name="ideal">The iDEAL payment source.</param>
    /// <param name="myBank">The MyBank payment source.</param>
    /// <param name="pTwentyFour">The P24 payment source.</param>
    /// <param name="sofort">The Sofort payment source.</param>
    /// <param name="trustuly">The Trustuly payment source.</param>
    /// <param name="applePay">The Apple Pay payment source.</param>
    /// <param name="googlePay">The Google Pay payment source.</param>
    /// <param name="venmo">The Venmo payment source.</param>
    public PaymentSource(CardSource cardSource, TokenSource token, PayPalSource payPal, BanContactSource banContact, BlikSource blik, EpsSource eps, GiroPaySource giroPay, IdealSource ideal, MyBankSource myBank, PTwentyFourSource pTwentyFour, SofortSource sofort, TrustulySource trustuly, ApplePaySource applePay, GooglePaySource googlePay, VenmoSource venmo)
    {
        CardSource = cardSource;
        Token = token;
        PayPal = payPal;
        BanContact = banContact;
        Blik = blik;
        Eps = eps;
        GiroPay = giroPay;
        Ideal = ideal;
        MyBank = myBank;
        PTwentyFour = pTwentyFour;
        Sofort = sofort;
        Trustuly = trustuly;
        ApplePay = applePay;
        GooglePay = googlePay;
        Venmo = venmo;
    }
}