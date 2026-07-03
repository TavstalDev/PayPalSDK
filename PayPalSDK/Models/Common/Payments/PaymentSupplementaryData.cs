using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents supplementary data for a PayPal payment transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentSupplementaryData
{
    /// <summary>
    /// Related identifiers for the payment transaction, such as order ID, authorization ID, and capture ID.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("related_ids")]
    public RelatedIds? RelatedIds { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}