using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums.Transactions;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents core transaction metadata and monetary breakdown values
/// returned by PayPal transaction reporting APIs.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionInfo
{
    /// <summary>
    /// Gets or sets the PayPal account identifier associated with the transaction.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("paypal_account_id")]
    [StringLength(24)]
    public string? PaypalAccountId { get; set; }
    
    /// <summary>
    /// Gets or sets the unique PayPal transaction identifier.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("transaction_id")]
    [StringLength(24)]
    public string? TransactionId { get; set; }
    
    /// <summary>
    /// Gets or sets a PayPal reference identifier linked to this transaction.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("paypal_reference_id")]
    [StringLength(24)]
    public string? PaypalReferenceId { get; set; }
    
    /// <summary>
    /// Gets or sets the type code for <see cref="PaypalReferenceId"/>.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("paypal_reference_id_type")]
    public EPaypalReferenceIdType? PaypalReferenceIdType { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction event code describing the event category.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("transaction_event_code")]
    [StringLength(5)]
    public string? TransactionEventCode { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction status code.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("transaction_status")]
    public ETransactionSearchStatus? TransactionStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the subject or title associated with the transaction.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("transaction_subject")]
    [StringLength(256)]
    public string? TransactionSubject { get; set; }
    
    /// <summary>
    /// Gets or sets an optional note attached to the transaction.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("transaction_note")]
    [StringLength(4000)]
    public string? TransactionNote { get; set; }
    
    /// <summary>
    /// Gets or sets the payment tracking identifier for correlating payment flows.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("payment_tracking_id")]
    [StringLength(127)]
    public string? PaymentTrackingId { get; set; }
    
    /// <summary>
    /// Gets or sets the bank-side reference identifier when available.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("bank_reference_id")]
    [StringLength(127)]
    public string? BankReferenceId { get; set; }
    
    /// <summary>
    /// Gets or sets the merchant invoice identifier associated with the transaction.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    /// <summary>
    /// Gets or sets a merchant-defined custom field value.
    /// </summary>
    [FluentMember(11)]
    [FluentSkippable]
    [JsonPropertyName("custom_field")]
    [StringLength(127)]
    public string? CustomField { get; set; }
    
    /// <summary>
    /// Gets or sets seller protection eligibility information.
    /// 01. Eligible; 02. Not eligible; 03. Partially eligible.
    /// </summary>
    [FluentMember(12)]
    [FluentSkippable]
    [JsonPropertyName("protection_eligibility")]
    [StringLength(2)]
    public string? ProtectionEligibility { get; set; }
    
    /// <summary>
    /// Gets or sets credit term details when applicable.
    /// </summary>
    [FluentMember(13)]
    [FluentSkippable]
    [JsonPropertyName("credit_term")]
    [StringLength(25)]
    public string? CreditTerm { get; set; }
    
    /// <summary>
    /// Gets or sets the payment method type used for the transaction.
    /// </summary>
    [FluentMember(14)]
    [FluentSkippable]
    [JsonPropertyName("payment_method_type")]
    [StringLength(20)]
    public string? PaymentMethodType { get; set; }
    
    /// <summary>
    /// Gets or sets the instrument type used to fund the transaction.
    /// </summary>
    [FluentMember(15)]
    [FluentSkippable]
    [JsonPropertyName("instrument_type")]
    [StringLength(64)]
    public string? InstrumentType { get; set; }
    
    /// <summary>
    /// Gets or sets a more specific instrument subtype.
    /// </summary>
    [FluentMember(16)]
    [FluentSkippable]
    [JsonPropertyName("instrument_sub_type")]
    [StringLength(64)]
    public string? InstrumentSubType { get; set; }
    
    /// <summary>
    /// Gets or sets the decline code when a transaction is declined.
    /// </summary>
    [FluentMember(17)]
    [FluentSkippable]
    [JsonPropertyName("decline_code")]
    [StringLength(50)]
    public string? DeclineCode { get; set; }
    
    /// <summary>
    /// Gets or sets the transaction initiation timestamp in ISO 8601 format.
    /// </summary>
    [FluentMember(18)]
    [FluentSkippable]
    [JsonPropertyName("transaction_initiation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionInitiationDate { get; set; }
    
    /// <summary>
    /// Gets or sets the last-updated timestamp for the transaction in ISO 8601 format.
    /// </summary>
    [FluentMember(19)]
    [FluentSkippable]
    [JsonPropertyName("transaction_updated_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionUpdatedDate { get; set; }
    
    /// <summary>
    /// Gets or sets the primary transaction amount.
    /// </summary>
    [FluentMember(20)]
    [FluentSkippable]
    [JsonPropertyName("transaction_amount")]
    public Money? TransactionAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the fee amount charged for the transaction.
    /// </summary>
    [FluentMember(21)]
    [FluentSkippable]
    [JsonPropertyName("fee_amount")]
    public Money? FeeAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the discount amount applied to the transaction.
    /// </summary>
    [FluentMember(22)]
    [FluentSkippable]
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the insurance amount associated with the transaction.
    /// </summary>
    [FluentMember(23)]
    [FluentSkippable]
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the sales tax amount for the transaction.
    /// </summary>
    [FluentMember(24)]
    [FluentSkippable]
    [JsonPropertyName("sales_tax_amount")]
    public Money? SalesTaxAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping amount charged in the transaction.
    /// </summary>
    [FluentMember(25)]
    [FluentSkippable]
    [JsonPropertyName("shipping_amount")]
    public Money? ShippingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets any discount applied to shipping charges.
    /// </summary>
    [FluentMember(26)]
    [FluentSkippable]
    [JsonPropertyName("shipping_discount_amount")]
    public Money? ShippingDiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets other miscellaneous amount components.
    /// </summary>
    [FluentMember(27)]
    [FluentSkippable]
    [JsonPropertyName("other_amount")]
    public Money? OtherAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the tip amount included in the transaction.
    /// </summary>
    [FluentMember(28)]
    [FluentSkippable]
    [JsonPropertyName("tip_amount")]
    public Money? TipAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the ending account balance after this transaction.
    /// </summary>
    [FluentMember(29)]
    [FluentSkippable]
    [JsonPropertyName("ending_balance")]
    public Money? EndingBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the available account balance after this transaction.
    /// </summary>
    [FluentMember(30)]
    [FluentSkippable]
    [JsonPropertyName("available_balance")]
    public Money? AvailableBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the transactional fee portion related to credit usage.
    /// </summary>
    [FluentMember(31)]
    [FluentSkippable]
    [JsonPropertyName("credit_transactional_fee")]
    public Money? CreditTransactionalFee { get; set; }
    
    /// <summary>
    /// Gets or sets the promotional fee portion related to credit usage.
    /// </summary>
    [FluentMember(32)]
    [FluentSkippable]
    [JsonPropertyName("credit_promotional_fee")]
    public Money? CreditPromotionalFee { get; set; }
    
    /// <summary>
    /// Gets or sets the annual percentage rate (APR) as a numeric string.
    /// </summary>
    [FluentMember(33)]
    [FluentSkippable]
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

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(34, "Build")]
    public void Build() { }
}