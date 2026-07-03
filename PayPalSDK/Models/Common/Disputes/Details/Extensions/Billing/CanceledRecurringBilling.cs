using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of a canceled recurring billing in a PayPal dispute, including expected refund and cancellation details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CanceledRecurringBilling
{
    /// <summary>
    /// Gets or sets the expected refund amount for the canceled recurring billing.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("expected_refund")]
    public Money? ExpectedRefund { get; set; }
    
    /// <summary>
    /// Gets or sets the details of the cancellation for the recurring billing.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}