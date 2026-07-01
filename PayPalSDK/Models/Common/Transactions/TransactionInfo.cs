using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents core transaction metadata and monetary breakdown values
/// returned by PayPal transaction reporting APIs.
/// </summary>
public class TransactionInfo
{
    /// <summary>
    /// Gets or sets the PayPal account identifier associated with the transaction.
    /// </summary>
    [JsonPropertyName("paypal_account_id")]
    [StringLength(24)]
    public string? PaypalAccountId { get; set; }
    
    /// <summary>
    /// Gets or sets the unique PayPal transaction identifier.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    [StringLength(24)]
    public string? TransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets a PayPal reference identifier linked to this transaction.
    /// </summary>
    [JsonPropertyName("paypal_reference_id")]
    [StringLength(24)]
    public string? PaypalReferenceId { get; set; }
    
    /// <summary>
    /// Gets or sets the type code for <see cref="PaypalReferenceId"/>.
    /// </summary>
    [JsonPropertyName("paypal_reference_id_type")]
    [StringLength(3)]
    public string? PaypalReferenceIdType { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction event code describing the event category.
    /// </summary>
    [JsonPropertyName("transaction_event_code")]
    [StringLength(5)]
    public string? TransactionEventCode { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction status code.
    /// </summary>
    [JsonPropertyName("transaction_status")]
    [StringLength(1)]
    public string? TransactionStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the subject or title associated with the transaction.
    /// </summary>
    [JsonPropertyName("transaction_subject")]
    [StringLength(256)]
    public string? TransactionSubject { get; set; }
    
    /// <summary>
    /// Gets or sets an optional note attached to the transaction.
    /// </summary>
    [JsonPropertyName("transaction_note")]
    [StringLength(4000)]
    public string? TransactionNote { get; set; }
    
    /// <summary>
    /// Gets or sets the payment tracking identifier for correlating payment flows.
    /// </summary>
    [JsonPropertyName("payment_tracking_id")]
    [StringLength(127)]
    public string? PaymentTrackingId { get; set; }
    
    /// <summary>
    /// Gets or sets the bank-side reference identifier when available.
    /// </summary>
    [JsonPropertyName("bank_reference_id")]
    [StringLength(127)]
    public string? BankReferenceId { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice identifier associated with the transaction.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    /// <summary>
    /// Gets or sets a merchant-defined custom field value.
    /// </summary>
    [JsonPropertyName("custom_field")]
    [StringLength(127)]
    public string? CustomField { get; set; }
    
    /// <summary>
    /// Gets or sets seller protection eligibility information.
    /// </summary>
    [JsonPropertyName("protection_eligibility")]
    [StringLength(2)]
    public string? ProtectionEligibility { get; set; }
    
    /// <summary>
    /// Gets or sets credit term details when applicable.
    /// </summary>
    [JsonPropertyName("credit_term")]
    [StringLength(25)]
    public string? CreditTerm { get; set; }
    
    /// <summary>
    /// Gets or sets the payment method type used for the transaction.
    /// </summary>
    [JsonPropertyName("payment_method_type")]
    [StringLength(20)]
    public string? PaymentMethodType { get; set; }
    
    /// <summary>
    /// Gets or sets the instrument type used to fund the transaction.
    /// </summary>
    [JsonPropertyName("instrument_type")]
    [StringLength(64)]
    public string? InstrumentType { get; set; }
    
    /// <summary>
    /// Gets or sets a more specific instrument subtype.
    /// </summary>
    [JsonPropertyName("instrument_sub_type")]
    [StringLength(64)]
    public string? InstrumentSubType { get; set; }
    
    /// <summary>
    /// Gets or sets the decline code when a transaction is declined.
    /// </summary>
    [JsonPropertyName("decline_code")]
    [StringLength(50)]
    public string? DeclineCode { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction initiation timestamp in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("transaction_initiation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionInitiationDate { get; set; }
    
    /// <summary>
    /// Gets or sets the last-updated timestamp for the transaction in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("transaction_updated_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionUpdatedDate { get; set; }
    
    /// <summary>
    /// Gets or sets the primary transaction amount.
    /// </summary>
    [JsonPropertyName("transaction_amount")]
    public Money? TransactionAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the fee amount charged for the transaction.
    /// </summary>
    [JsonPropertyName("fee_amount")]
    public Money? FeeAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the discount amount applied to the transaction.
    /// </summary>
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the insurance amount associated with the transaction.
    /// </summary>
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the sales tax amount for the transaction.
    /// </summary>
    [JsonPropertyName("sales_tax_amount")]
    public Money? SalesTaxAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping amount charged in the transaction.
    /// </summary>
    [JsonPropertyName("shipping_amount")]
    public Money? ShippingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets any discount applied to shipping charges.
    /// </summary>
    [JsonPropertyName("shipping_discount_amount")]
    public Money? ShippingDiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets other miscellaneous amount components.
    /// </summary>
    [JsonPropertyName("other_amount")]
    public Money? OtherAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the tip amount included in the transaction.
    /// </summary>
    [JsonPropertyName("tip_amount")]
    public Money? TipAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the ending account balance after this transaction.
    /// </summary>
    [JsonPropertyName("ending_balance")]
    public Money? EndingBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the available account balance after this transaction.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public Money? AvailableBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the transactional fee portion related to credit usage.
    /// </summary>
    [JsonPropertyName("credit_transactional_fee")]
    public Money? CreditTransactionalFee { get; set; }
    
    /// <summary>
    /// Gets or sets the promotional fee portion related to credit usage.
    /// </summary>
    [JsonPropertyName("credit_promotional_fee")]
    public Money? CreditPromotionalFee { get; set; }
    
    /// <summary>
    /// Gets or sets the annual percentage rate (APR) as a numeric string.
    /// </summary>
    [JsonPropertyName("annual_percentage_rate")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? AnnualPercentageRate { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> value of <see cref="TransactionInitiationDate"/>,
    /// or <see langword="null"/> when unavailable or invalid.
    /// </summary>
    public DateTime? TransactionInitiationDateAsDateTime => DateTimeHelper.FromISO8601(TransactionInitiationDate);
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> value of <see cref="TransactionUpdatedDate"/>,
    /// or <see langword="null"/> when unavailable or invalid.
    /// </summary>
    public DateTime? TransactionUpdatedDateAsDateTime => DateTimeHelper.FromISO8601(TransactionUpdatedDate);
}