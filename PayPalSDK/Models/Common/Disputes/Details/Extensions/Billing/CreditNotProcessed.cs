using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Merchandize;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of a credit not processed in a PayPal dispute, including issue type, agreed refund details, expected refund, cancellation details, product details, and service details.
/// </summary>
public class CreditNotProcessed
{
    /// <summary>
    /// Gets or sets the issue type associated with the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("issue_type")]
    [StringLength(255)]
    public string? IssueType { get; set; }
    
    /// <summary>
    /// Gets or sets the agreed refund details for the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("agreed_refund_details")]
    public AgreedRefundDetails? AgreedRefundDetails { get; set; }

    /// <summary>
    /// Gets or sets the expected refund amount for the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("expected_refund")]
    public Money? ExpectedRefund { get; set; }

    /// <summary>
    /// Gets or sets the details of the cancellation for the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("cancellation_details")]
    public CancellationDetails? CancellationDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the details of the product for the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("product_details")]
    public ProductDetails? ProductDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the details of the service for the credit not processed in the dispute.
    /// </summary>
    [JsonPropertyName("service_details")]
    public ServiceDetails? ServiceDetails { get; set; }
}