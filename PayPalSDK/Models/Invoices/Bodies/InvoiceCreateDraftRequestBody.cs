using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Invoices;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for creating a draft invoice, including recipients, items, details, configuration, and payment information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceCreateDraftRequestBody
{
    /// <summary>
    /// Gets or sets the list of primary recipients for the invoice.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("primary_recipients")]
    public List<Recipient>? PrimaryRecipients { get; set; }

    /// <summary>
    /// Gets or sets the list of additional recipient email addresses.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("additional_recipients")]
    public List<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Gets or sets the list of items included in the invoice.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<InvoiceItem>? Items { get; set; }

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
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("invoicer")]
    public Invoicer? Invoicer { get; set; }

    /// <summary>
    /// Gets or sets the configuration options for the invoice.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("configuration")]
    public InvoiceConfig? Configuration { get; set; }
    
    /// <summary>
    /// Gets or sets the total amount breakdown for the invoice.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public InvoiceAmount? Amount { get; set; }

    /// <summary>
    /// Gets or sets the list of authorized payments associated with the invoice.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("payments")]
    public List<AuthorizedPaymentBody>? Payments { get; set; }

    /// <summary>
    /// Gets or sets the list of refund payments associated with the invoice.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("refunds")]
    public List<RefundPaymentBody>? Refunds { get; set; }
    
    /// <summary>
    /// Gets or sets invoice behavior and presentation settings,
    /// such as payment terms, reminders, and display preferences.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("settings")]
    public InvoiceSettings? Settings { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(10, "Build")]
    public void Build() { }
}