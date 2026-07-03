using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Orders.Bodies;

/// <summary>
/// Represents the request body for capturing an order within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class OrderCaptureRequestBody
{
    /// <summary>
    /// Gets or sets the payment source for the order capture.
    /// </summary>
    /// <remarks>
    /// This field is optional and specifies the payment method or source used for the transaction.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("payment_source")]
    public PaymentSource? PaymentSource { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}