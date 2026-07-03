using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to record a refund against an invoice by refund ID.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceRecordRefundBody
{
    /// <summary>
    /// Gets or sets the refund identifier.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("refund_id")]
    [StringLength(22)]
    public string? RefundId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}