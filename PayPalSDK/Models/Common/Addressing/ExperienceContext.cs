using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents the context for configuring the PayPal payment experience.
/// </summary>
[DataContract]
public class ExperienceContext
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site.
    /// </summary>
    [DataMember(Name = "brand_name", EmitDefaultValue = false)]
    [StringLength(127)]
    public string BrandName { get; set; }

    /// <summary>
    /// The type of landing page to show on the PayPal site for customer checkout.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.Experience.LandingPages"/>.
    /// </summary>
    [DataMember(Name = "landing_page", EmitDefaultValue = false)]
    [StringLength(13)]
    public string LandingPage { get; set; }

    /// <summary>
    /// The shipping preference for the PayPal payment experience.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.Experience.ShippingPreference"/>.
    /// </summary>
    [DataMember(Name = "shipping_preference", EmitDefaultValue = false)]
    [StringLength(24)]
    public string ShippingPreference { get; set; }

    /// <summary>
    /// Configures the user action for the checkout flow.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.Experience.UserAction"/>.
    /// </summary>
    [DataMember(Name = "user_action", EmitDefaultValue = false)]
    [StringLength(8)]
    public string UserAction { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after approving the payment.
    /// </summary>
    [DataMember(Name = "return_url", EmitDefaultValue = false)]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after canceling the payment.
    /// </summary>
    [DataMember(Name = "cancel_url", EmitDefaultValue = false)]
    public string CancelUrl { get; set; }

    /// <summary>
    /// The BCP 47-formatted locale of pages displayed during the PayPal payment experience.
    /// </summary>
    [DataMember(Name = "locale", EmitDefaultValue = false)]
    [StringLength(10)]
    [RegularExpression("^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$")]
    public string Locale { get; set; }

    /// <summary>
    /// The merchant-preferred payment methods.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.Experience.PaymentPreference"/>.
    /// </summary>
    [DataMember(Name = "payment_method_preference", EmitDefaultValue = false)]
    [StringLength(255)]
    public string PaymentMethodPreference { get; set; }

    /// <summary>
    /// The contact preference for the merchant.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.Experience.ContactPreference"/>.
    /// </summary>
    [DataMember(Name = "contact_preference", EmitDefaultValue = false)]
    [StringLength(24)]
    public string ContactPreference { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExperienceContext"/> class.
    /// </summary>
    /// <param name="brandName">The business name override.</param>
    /// <param name="landingPage">The landing page preference.</param>
    /// <param name="shippingPreference">The shipping preference.</param>
    /// <param name="userAction">The user action preference.</param>
    /// <param name="returnUrl">The return URL after payment approval.</param>
    /// <param name="cancelUrl">The cancel URL after payment cancellation.</param>
    /// <param name="locale">The locale for the PayPal experience.</param>
    /// <param name="paymentMethodPreference">The preferred payment methods.</param>
    /// <param name="contactPreference">The contact preference.</param>
    public ExperienceContext(string brandName, string landingPage, string shippingPreference, string userAction,
        string returnUrl, string cancelUrl, string locale, string paymentMethodPreference, string contactPreference)
    {
        BrandName = brandName;
        LandingPage = landingPage;
        ShippingPreference = shippingPreference;
        UserAction = userAction;
        ReturnUrl = returnUrl;
        CancelUrl = cancelUrl;
        Locale = locale;
        PaymentMethodPreference = paymentMethodPreference;
        ContactPreference = contactPreference;
    }
}