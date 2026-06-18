using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

[DataContract]
public class BillingDisputeProperties
{
    [JsonPropertyName("duplicate_transaction")]
    public DuplicateTransaction? DuplicateTransaction { get; set; }
    
    [JsonPropertyName("incorrect_transaction_amount")]
    public IncorrectTransactionAmount? IncorrectTransactionAmount { get; set; }
    
    [JsonPropertyName("payment_by_other_means")]
    public PaymentByOtherMeans? PaymentByOtherMeans { get; set; }
    
    [JsonPropertyName("credit_not_processed")]
    public CreditNotProcessed? CreditNotProcessed { get; set; }
    
    [JsonPropertyName("canceled_recurring_billing")]
    public CanceledRecurringBilling? CanceledRecurringBilling { get; set; }
}