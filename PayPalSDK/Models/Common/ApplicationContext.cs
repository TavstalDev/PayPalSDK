using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents the application context for a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ApplicationContext
{
    /// <summary>
    /// Gets or sets the brand name to be displayed in the PayPal checkout experience.
    /// </summary>
    /// <remarks>
    /// Maximum length: 127 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("brand_name")]
    [StringLength(127)]
    public string? BrandName { get; set; }

    /// <summary>
    /// Gets or sets the URL to which the customer is redirected after approving the payment.
    /// </summary>
    /// <remarks>
    /// Maximum length: 4000 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("return_url")]
    [StringLength(4000)]
    public string? ReturnUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL to which the customer is redirected if they cancel the payment.
    /// </summary>
    /// <remarks>
    /// Maximum length: 4000 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("cancel_url")]
    [StringLength(4000)]
    public string? CancelUrl { get; set; }

    /// <summary>
    /// Gets or sets the locale for the PayPal checkout experience.
    /// </summary>
    /// <remarks>
    /// The locale must follow the format: `^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$`.
    /// Maximum length: 10 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("locale")]
    [StringLength(10)]
    [RegularExpression("^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}|[0-9]{3}))?$")]
    public string? Locale { get; set; }

    /// <summary>
    /// Gets or sets the stored payment source for the transaction.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("stored_payment_source")]
    public PaymentSource? StoredPaymentSource { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}