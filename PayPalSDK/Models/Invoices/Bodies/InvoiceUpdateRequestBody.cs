using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Invoices;
using System.ComponentModel.DataAnnotations;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for updating a PayPal invoice, including recipients, items, details, and configuration.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the list of primary recipients for the invoice.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("primary_recipients")]
    public List<Recipient>? PrimaryRecipients { get; set; }

    /// <summary>
    /// Gets or sets the list of additional recipients for the invoice.
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
    /// Gets or sets the detailed information about the invoice.
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
    /// Gets or sets the configuration settings for the invoice.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("configuration")]
    public InvoiceConfig? Configuration { get; set; }

    /// <summary>
    /// Gets or sets the breakdown of the total amount for the invoice.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public InvoiceAmount? Amount { get; set; }
    
    /// <summary>
    /// Gets or sets invoice behavior and presentation settings,
    /// such as payment terms, reminders, and display preferences.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("settings")]
    public InvoiceSettings? Settings { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}