using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions;

/// <summary>
/// Represents billing-specific dispute extension properties grouped by billing issue type.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class BillingDisputeProperties
{
    /// <summary>
    /// Gets or sets details for disputes involving duplicate transactions.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("duplicate_transaction")]
    public DuplicateTransaction? DuplicateTransaction { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes involving an incorrect transaction amount.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("incorrect_transaction_amount")]
    public IncorrectTransactionAmount? IncorrectTransactionAmount { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes where payment was made by other means.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payment_by_other_means")]
    public PaymentByOtherMeans? PaymentByOtherMeans { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes where an expected credit was not processed.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("credit_not_processed")]
    public CreditNotProcessed? CreditNotProcessed { get; set; }
    
    /// <summary>
    /// Gets or sets details for disputes related to canceled recurring billing.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("canceled_recurring_billing")]
    public CanceledRecurringBilling? CanceledRecurringBilling { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}