using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;
using Tavstal.PayPalSDK.Models.Enums.Payment;
using Tavstal.PayPalSDK.Models.Enums.Shipping;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents the context for configuring the PayPal payment experience.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ExperienceContext
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("brand_name")]
    [StringLength(127)]
    public string? BrandName { get; set; }

    /// <summary>
    /// The type of landing page to show on the PayPal site for customer checkout.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("landing_page")]
    public EPaymentLandingPageType? LandingPage { get; set; }

    /// <summary>
    /// The shipping preference for the PayPal payment experience.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("shipping_preference")]
    public EShippingPreference? ShippingPreference { get; set; }

    /// <summary>
    /// Configures the user action for the checkout flow.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("user_action")]
    public EUserAction? UserAction { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after approving the payment.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("return_url")]
    public string? ReturnUrl { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after canceling the payment.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; set; }

    /// <summary>
    /// The BCP 47-formatted locale of pages displayed during the PayPal payment experience.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("locale")]
    [StringLength(10)]
    [RegularExpression("^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$")]
    public string? Locale { get; set; }

    /// <summary>
    /// The merchant-preferred payment methods.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("payment_method_preference")]
    public EPaymentMethodPreference? PaymentMethodPreference { get; set; }

    /// <summary>
    /// The contact preference for the merchant.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("contact_preference")]
    public EPaymentContactPreference? ContactPreference { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(9, "Build")]
    public void Build() { }
}