using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

[DataContract]
public class CreditNotProcessed
{
    [JsonPropertyName("issue_type")]
    [StringLength(255)]
    public string? IssueType { get; set; }
    
    [JsonPropertyName("agreed_refund_details")]
    public AgreedRefundDetails? AgreedRefundDetails { get; set; }

    [JsonPropertyName("expected_refund")]
    public Money? ExpectedRefund { get; set; }

    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
    
    [JsonPropertyName("product_details")]
    public ProductDetails? ProductDetails { get; set; }
    
    [JsonPropertyName("service_details")]
    public ServiceDetails? ServiceDetails { get; set; }
}