using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Payments.Bodies;

/// <summary>
/// Represents the body of a payment reauthorization request.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentReauthorizeRequestBody
{
    /// <summary>
    /// The monetary amount to be reauthorized.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}