using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

[DataContract]
public class CanceledRecurringBilling
{
    [JsonPropertyName("expected_refund")]
    public Money? ExpectedRefund { get; set; }
    
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
}