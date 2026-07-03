using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents related identifiers for a PayPal payment transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class RelatedIds
{
    /// <summary>
    /// The unique identifier for the PayPal order.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; set; }

    /// <summary>
    /// The unique identifier for the authorization associated with the payment.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("authorization_id")]
    public string? AuthorizationId { get; set; }

    /// <summary>
    /// The unique identifier for the capture associated with the payment.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("capture_id")]
    public string? CaptureId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}