using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents the payments information for a purchase unit, including authorizations, captures, and refunds.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentsUnit
{
    /// <summary>
    /// Gets or sets the list of payment authorizations associated with the purchase unit.
    /// </summary>
    /// <remarks>
    /// This property contains details of all payment authorizations.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("authorizations")]
    public List<PaymentAuthorization>? Authorizations { get; set; }

    /// <summary>
    /// Gets or sets the list of payment captures associated with the purchase unit.
    /// </summary>
    /// <remarks>
    /// This property contains details of all payment captures.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("captures")]
    public List<PaymentCapture>? Captures { get; set; }

    /// <summary>
    /// Gets or sets the list of payment refunds associated with the purchase unit.
    /// </summary>
    /// <remarks>
    /// This property contains details of all payment refunds.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("refunds")]
    public List<RefundPaymentBody>? Refunds { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}