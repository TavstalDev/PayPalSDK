using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Plans;

/// <summary>
/// Represents the payment source information for a subscriber.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriberPaymentSource
{
    /// <summary>
    /// Gets or sets the subscriber's card information used for payment.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("card")]
    public SubscriberCard? Card { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}