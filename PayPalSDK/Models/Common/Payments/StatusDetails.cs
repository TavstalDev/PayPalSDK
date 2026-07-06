using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Payment;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the details of a payment status, including the reason for the status.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class StatusDetails
{
    /// <summary>
    /// The reason for the payment status.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    public EAuthorizationIncompleteStatus? Reason { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}