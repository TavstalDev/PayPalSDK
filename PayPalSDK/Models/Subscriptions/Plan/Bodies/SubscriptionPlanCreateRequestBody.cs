using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Billing;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Plans;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Subscriptions;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Plan.Bodies;

/// <summary>
/// Represents the request body for creating a subscription plan in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionPlanCreateRequestBody
{
    /// <summary>
    /// Gets or sets the product ID associated with the plan.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a string with a maximum length of 22 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("product_id")]
    [StringLength(22)]
    [Required]
    public string? ProductId { get; set; }

    /// <summary>
    /// Gets or sets the name of the plan.
    /// </summary>
    /// <remarks>
    /// This field is required and must be a string with a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("name")]
    [StringLength(127)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the status of the plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and must be a string with a maximum length of 24 characters.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public EPlanStatus? Status { get; set; }

    /// <summary>
    /// Gets or sets the description of the plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and must be a string with a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("description")]
    [StringLength(127)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the billing cycles associated with the plan.
    /// </summary>
    /// <remarks>
    /// This field is required and represents a list of billing cycle objects.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("billing_cycles")]
    public List<BillingCycle>? BillingCycles { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether quantity is supported for the plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies if the plan supports quantity-based subscriptions.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("quantity_supported")]
    public bool QuantitySupported { get; set; }

    /// <summary>
    /// Gets or sets the payment preferences for the plan.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the payment preferences object.
    /// </remarks>
    [FluentMember(3)]
    [Required]
    [JsonPropertyName("payment_preferences")]
    public PlanPaymentPreference? PaymentPreference { get; set; }

    /// <summary>
    /// Gets or sets the tax information for the plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the tax details for the plan.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("taxes")]
    public Taxes? Taxes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}