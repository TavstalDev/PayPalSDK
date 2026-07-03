using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.Plans;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Bodies;

/// <summary>
/// Represents the request body for creating a subscription.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionCreateRequestBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the subscription plan.
    /// </summary>
    /// <remarks>
    /// The plan ID must have a maximum length of 26 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("plan_id")]
    [StringLength(26)]
    public string? PlanId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the subscription plan.
    /// </summary>
    /// <remarks>
    /// The quantity can have a maximum length of 32 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("quantity")]
    [StringLength(32)]
    public string? Quantity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the subscription should auto-renew.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("auto_renewal")]
    public bool AutoRenewal { get; set; }

    /// <summary>
    /// Gets or sets a custom identifier for the subscription.
    /// </summary>
    /// <remarks>
    /// The custom ID can have a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("custom_id")]
    [StringLength(127)]
    public string? CustomId { get; set; }

    /// <summary>
    /// Gets or sets the start time of the subscription.
    /// </summary>
    /// <remarks>
    /// The start time must follow the format "YYYY-MM-DDTHH:mm:ss.sssZ" or include a timezone offset.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("start_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Gets or sets the shipping amount for the subscription.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("shipping_amount")]
    public Money? ShippingAmount { get; set; }

    /// <summary>
    /// Gets or sets the subscriber's information.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("subscriber")]
    public Subscriber? Subscriber { get; set; }

    /// <summary>
    /// Gets or sets the application context for the subscription.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("application_context")]
    public ApplicationContext? ApplicationContext { get; set; }

    /// <summary>
    /// Gets or sets the subscription plan details.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("plan")]
    public SubscriberPlan? Plan { get; set; }
    
    /// <summary>
    /// Gets the start time of the subscription as a nullable DateTime object.
    /// </summary>
    public DateTime? StartTimeAsDateTime => DateTimeHelper.FromISO8601(StartTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(9, "Build")]
    public void Build() { }
}