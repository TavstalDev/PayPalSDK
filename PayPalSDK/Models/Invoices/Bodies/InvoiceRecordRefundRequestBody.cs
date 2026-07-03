using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to record a refund against an invoice.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceRecordRefundRequestBody
{
    /// <summary>
    /// Gets or sets the refund date in <c>yyyy-MM-dd</c> format.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("refund_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? RefundDate { get; set; }
    
    /// <summary>
    /// Gets or sets the refund amount.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }
    
    /// <summary>
    /// Gets or sets the payment method used for the refund.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("method")]
    [StringLength(255)]
    [RegularExpression("^[\\S\\s]*$")]
    public string? Method { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}