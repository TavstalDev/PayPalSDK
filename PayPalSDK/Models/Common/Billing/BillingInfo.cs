using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents the billing information associated with a subscription or payment plan.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class BillingInfo
{
    /// <summary>
    /// Gets or sets the list of cycle executions for the billing plan.
    /// </summary>
    /// <remarks>
    /// Each cycle execution provides details about the execution of a billing cycle.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("cycle_executions")]
    public List<CycleExecution>? CycleExecutions { get; set; }

    /// <summary>
    /// Gets or sets the count of failed payments.
    /// </summary>
    /// <remarks>
    /// This value represents the total number of payment failures for the billing plan.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("failed_payment_count")]
    public int FailedPaymentCount { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance for the billing plan.
    /// </summary>
    /// <remarks>
    /// The balance is represented as a <see cref="Money"/> object.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("outstanding_balance")]
    public Money? OutstandingBalance { get; set; }

    /// <summary>
    /// Gets or sets the details of the last payment made.
    /// </summary>
    /// <remarks>
    /// The last payment is represented as a <see cref="LastPayment"/> object.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("last_payment")]
    public LastPayment? LastPayment { get; set; }
    
    /// <summary>
    /// Gets or sets the time for the next billing cycle.
    /// </summary>
    /// <remarks>
    /// The time must follow the format "YYYY-MM-DDTHH:mm:ss.sssZ" or include a timezone offset.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("next_billing_time")]
    public string? NextBillingTime { get; set; }

    /// <summary>
    /// Gets or sets the time for the final payment in the billing plan.
    /// </summary>
    /// <remarks>
    /// The time must follow the format "YYYY-MM-DDTHH:mm:ss.sssZ" or include a timezone offset.
    /// </remarks>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("final_payment_time")]
    public string? FinalPaymentTime { get; set; }

    /// <summary>
    /// Gets or sets the details of the last failed payment.
    /// </summary>
    /// <remarks>
    /// The last failed payment is represented as a <see cref="FailedPayment"/> object.
    /// </remarks>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("last_failed_payment")]
    public FailedPayment? LastFailedPayment { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="NextBillingTime"/>, if valid.
    /// </summary>
    public DateTime? NextBillingTimeAsDateTime => DateTimeHelper.FromISO8601(NextBillingTime);
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> representation of <see cref="FinalPaymentTime"/>, if valid.
    /// </summary>
    public DateTime? FinalPaymentTimeAsDateTime => DateTimeHelper.FromISO8601(FinalPaymentTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(7, "Build")]
    public void Build() { }
}