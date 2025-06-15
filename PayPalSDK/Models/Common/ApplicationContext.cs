using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents the application context for a PayPal transaction.
/// </summary>
[DataContract]
public class ApplicationContext
{
    /// <summary>
    /// Gets or sets the brand name to be displayed in the PayPal checkout experience.
    /// </summary>
    /// <remarks>
    /// Maximum length: 127 characters.
    /// </remarks>
    [DataMember(Name = "brand_name", EmitDefaultValue = false)]
    [StringLength(127)]
    public string BrandName { get; set; }

    /// <summary>
    /// Gets or sets the URL to which the customer is redirected after approving the payment.
    /// </summary>
    /// <remarks>
    /// Maximum length: 4000 characters.
    /// </remarks>
    [DataMember(Name = "return_url", EmitDefaultValue = false)]
    [StringLength(4000)]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL to which the customer is redirected if they cancel the payment.
    /// </summary>
    /// <remarks>
    /// Maximum length: 4000 characters.
    /// </remarks>
    [DataMember(Name = "cancel_url", EmitDefaultValue = false)]
    [StringLength(4000)]
    public string CancelUrl { get; set; }

    /// <summary>
    /// Gets or sets the locale for the PayPal checkout experience.
    /// </summary>
    /// <remarks>
    /// The locale must follow the format: `^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$`.
    /// Maximum length: 10 characters.
    /// </remarks>
    [DataMember(Name = "locale", EmitDefaultValue = false)]
    [StringLength(10)]
    [RegularExpression("^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or sets the stored payment source for the transaction.
    /// </summary>
    [DataMember(Name = "stored_payment_source", EmitDefaultValue = false)]
    public PaymentSource StoredPaymentSource { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationContext"/> class.
    /// </summary>
    /// <param name="brandName">The brand name to be displayed in the PayPal checkout experience.</param>
    /// <param name="returnUrl">The URL to redirect the customer after approving the payment.</param>
    /// <param name="cancelUrl">The URL to redirect the customer if they cancel the payment.</param>
    /// <param name="locale">The locale for the PayPal checkout experience.</param>
    /// <param name="storedPaymentSource">The stored payment source for the transaction.</param>
    public ApplicationContext(string brandName, string returnUrl, string cancelUrl, string locale, PaymentSource storedPaymentSource)
    {
        BrandName = brandName;
        ReturnUrl = returnUrl;
        CancelUrl = cancelUrl;
        Locale = locale;
        StoredPaymentSource = storedPaymentSource;
    }
}