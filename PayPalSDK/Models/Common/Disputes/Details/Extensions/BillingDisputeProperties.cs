using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

/// <summary>
/// Represents billing-specific dispute extension properties grouped by billing issue type.
/// </summary>
[DataContract]
public class BillingDisputeProperties
{
    /// <summary>
    /// Gets or sets details for disputes involving duplicate transactions.
    /// </summary>
    [JsonPropertyName("duplicate_transaction")]
    public DuplicateTransaction? DuplicateTransaction { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes involving an incorrect transaction amount.
    /// </summary>
    [JsonPropertyName("incorrect_transaction_amount")]
    public IncorrectTransactionAmount? IncorrectTransactionAmount { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes where payment was made by other means.
    /// </summary>
    [JsonPropertyName("payment_by_other_means")]
    public PaymentByOtherMeans? PaymentByOtherMeans { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes where an expected credit was not processed.
    /// </summary>
    [JsonPropertyName("credit_not_processed")]
    public CreditNotProcessed? CreditNotProcessed { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes related to canceled recurring billing.
    /// </summary>
    [JsonPropertyName("canceled_recurring_billing")]
    public CanceledRecurringBilling? CanceledRecurringBilling { get; set; }
}