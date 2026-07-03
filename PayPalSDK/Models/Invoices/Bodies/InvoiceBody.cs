using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Invoices;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the full details of a PayPal invoice, including recipients, items, status, configuration, payments, and refunds.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceBody
{
    /// <summary>
    /// Gets or sets the unique identifier of the invoice.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(30)]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the parent invoice ID, if this invoice is related to another invoice.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("parent_id")]
    [StringLength(30)]
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the list of primary recipients for the invoice.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("primary_recipients")]
    public List<Recipient>? PrimaryRecipients { get; set; }

    /// <summary>
    /// Gets or sets the list of additional recipient email addresses.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("additional_recipients")]
    public List<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Gets or sets the list of items included in the invoice.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<InvoiceItem>? Items { get; set; }

    /// <summary>
    /// Gets or sets the list of related links for the invoice.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Gets or sets the current status of the invoice.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the detailed information for the invoice.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("detail")]
    public Detail? Detail { get; set; }

    /// <summary>
    /// Gets or sets the invoicer information for the invoice.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("invoicer")]
    public Invoicer? Invoicer { get; set; }

    /// <summary>
    /// Gets or sets the configuration options for the invoice.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("configuration")]
    public InvoiceConfig? Configuration { get; set; }

    /// <summary>
    /// Gets or sets the total amount breakdown for the invoice.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public MoneyBreakdown? Amount { get; set; }

    /// <summary>
    /// Gets or sets the amount due for the invoice.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("due_amount")]
    public Money? DueAmount { get; set; }

    /// <summary>
    /// Gets or sets the gratuity (tip) amount for the invoice.
    /// </summary>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("gratuity")]
    public Money? Gratuity { get; set; }

    /// <summary>
    /// Gets or sets the list of payments made towards the invoice.
    /// </summary>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("payments")]
    public List<InvoicePayment>? Payments { get; set; }

    /// <summary>
    /// Gets or sets the list of refunds issued for the invoice.
    /// </summary>
    [FluentMember(14)]
    [FluentSkippable]
    [JsonPropertyName("refunds")]
    public List<InvoiceRefund>? Refunds { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(15, "Build")]
    public void Build() { }
}