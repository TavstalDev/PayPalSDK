using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body used to filter and list invoices from the PayPal Invoicing API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceListRequestBody
{
    /// <summary>
    /// Gets or sets the recipient's email address.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 254 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("recipient_email")]
    [StringLength(254)]
    public string? RecipientEmail { get; set; }
    
    /// <summary>
    /// Gets or sets the recipient's first name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("recipient_first_name")]
    [StringLength(140)]
    public string? RecipientFirstName { get; set; }
    
    /// <summary>
    /// Gets or sets the recipient's last name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 140 characters.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("recipient_last_name")]
    [StringLength(140)]
    public string? RecipientLastName { get; set; }
    
    /// <summary>
    /// Gets or sets the recipient's business name.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("recipient_business_name")]
    [StringLength(300)]
    public string? RecipientBusinessName { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice status filters.
    /// </summary>
    /// <remarks>
    /// This field is optional and can contain one or more status values to match against.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public List<string>? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice reference identifier.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 120 characters.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("reference")]
    [StringLength(120)]
    public string? Reference { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice memo.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 500 characters.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("memo")]
    [StringLength(500)]
    public string? Memo { get; set; }
    
    /// <summary>
    /// Gets or sets the payment date range filter.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to filter invoices by payment date.
    /// </remarks>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("payment_date_range")]
    public DateRange?  PaymentDateRange { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether archived invoices should be included.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to include or exclude archived invoices from the results.
    /// </remarks>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("archived")]
    public bool? Archived { get; set; }
    
    /// <summary>
    /// Gets or sets the list of fields to include in the response.
    /// </summary>
    /// <remarks>
    /// This field is optional and allows callers to request specific invoice fields only.
    /// </remarks>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("fields")]
    public List<string>? Fields { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice currency code.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 3 characters, typically representing an ISO 4217 currency code.
    /// </remarks>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("currency_code")]
    [StringLength(3)]
    public string? CurrencyCode { get; set; }
    
    /// <summary>
    /// Gets or sets the total amount range filter.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to filter invoices by their total monetary value.
    /// </remarks>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("total_amount_range")]
    public MoneyRange?  TotalAmountRange { get; set; }
    
    /// <summary>
    /// Gets or sets the invoice date range filter.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to filter invoices by invoice date.
    /// </remarks>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("invoice_date_range")]
    public DateRange?  InvoiceDateRange { get; set; }
    
    /// <summary>
    /// Gets or sets the due date range filter.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to filter invoices by due date.
    /// </remarks>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("due_date_range")]
    public DateRange?  DueDateRange { get; set; }
    
    /// <summary>
    /// Gets or sets the creation date range filter.
    /// </summary>
    /// <remarks>
    /// This field is optional and can be used to filter invoices by creation date.
    /// </remarks>
    [FluentMember(14)]
    [FluentSkippable]
    [JsonPropertyName("creation_date_range")]
    public DateRange?  CreationDateRange { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(15, "Build")]
    public void Build() { }
}