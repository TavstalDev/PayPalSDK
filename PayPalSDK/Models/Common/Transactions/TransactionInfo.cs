using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionInfo
{
    [JsonPropertyName("paypal_account_id")]
    [StringLength(24)]
    public string? PaypalAccountId { get; set; }
    
    [JsonPropertyName("transaction_id")]
    [StringLength(24)]
    public string? TransactionId { get; set; }
    
    [JsonPropertyName("paypal_reference_id")]
    [StringLength(24)]
    public string? PaypalReferenceId { get; set; }
    
    [JsonPropertyName("paypal_reference_id_type")]
    [StringLength(3)]
    public string? PaypalReferenceIdType { get; set; }
    
    [JsonPropertyName("transaction_event_code")]
    [StringLength(5)]
    public string? TransactionEventCode { get; set; }
    
    [JsonPropertyName("transaction_status")]
    [StringLength(1)]
    public string? TransactionStatus { get; set; }
    
    [JsonPropertyName("transaction_subject")]
    [StringLength(256)]
    public string? TransactionSubject { get; set; }
    
    [JsonPropertyName("transaction_note")]
    [StringLength(4000)]
    public string? TransactionNote { get; set; }
    
    [JsonPropertyName("payment_tracking_id")]
    [StringLength(127)]
    public string? PaymentTrackingId { get; set; }
    
    [JsonPropertyName("bank_reference_id")]
    [StringLength(127)]
    public string? BankReferenceId { get; set; }
    
    [JsonPropertyName("invoice_id")]
    [StringLength(127)]
    public string? InvoiceId { get; set; }
    
    [JsonPropertyName("custom_field")]
    [StringLength(127)]
    public string? CustomField { get; set; }
    
    [JsonPropertyName("protection_eligibility")]
    [StringLength(2)]
    public string? ProtectionEligibility { get; set; }
    
    [JsonPropertyName("credit_term")]
    [StringLength(25)]
    public string? CreditTerm { get; set; }
    
    [JsonPropertyName("payment_method_type")]
    [StringLength(20)]
    public string? PaymentMethodType { get; set; }
    
    [JsonPropertyName("instrument_type")]
    [StringLength(64)]
    public string? InstrumentType { get; set; }
    
    [JsonPropertyName("instrument_sub_type")]
    [StringLength(64)]
    public string? InstrumentSubType { get; set; }
    
    [JsonPropertyName("decline_code")]
    [StringLength(50)]
    public string? DeclineCode { get; set; }
    
    [JsonPropertyName("transaction_initiation_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionInitiationDate { get; set; }
    
    [JsonPropertyName("transaction_updated_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? TransactionUpdatedDate { get; set; }
    
    [JsonPropertyName("transaction_amount")]
    public Money? TransactionAmount { get; set; }
    
    [JsonPropertyName("fee_amount")]
    public Money? FeeAmount { get; set; }
    
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; set; }
    
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; set; }
    
    [JsonPropertyName("sales_tax_amount")]
    public Money? SalesTaxAmount { get; set; }
    
    [JsonPropertyName("shipping_amount")]
    public Money? ShippingAmount { get; set; }
    
    [JsonPropertyName("shipping_discount_amount")]
    public Money? ShippingDiscountAmount { get; set; }
    
    [JsonPropertyName("other_amount")]
    public Money? OtherAmount { get; set; }
    
    [JsonPropertyName("tip_amount")]
    public Money? TipAmount { get; set; }
    
    [JsonPropertyName("ending_balance")]
    public Money? EndingBalance { get; set; }
    
    [JsonPropertyName("available_balance")]
    public Money? AvailableBalance { get; set; }
    
    [JsonPropertyName("credit_transactional_fee")]
    public Money? CreditTransactionalFee { get; set; }
    
    [JsonPropertyName("credit_promotional_fee")]
    public Money? CreditPromotionalFee { get; set; }
    
    [JsonPropertyName("annual_percentage_rate")]
    [RegularExpression("^((-?[0-9]+)|(-?([0-9]+)?[.][0-9]+))$")]
    public string? AnnualPercentageRate { get; set; }
}