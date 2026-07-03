using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the details of a failed payment.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class FailedPayment
{
    /// <summary>
    /// Gets or sets the reason code for the payment failure.
    /// </summary>
    /// <remarks>
    /// The reason code must match one of the values defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentReasonCode"/>.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("reason_code")]
    [StringLength(120)]
    public string? ReasonCode { get; set; }

    /// <summary>
    /// Gets or sets the amount of the failed payment.
    /// </summary>
    /// <remarks>
    /// The amount is represented as a <see cref="Money"/> object.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the time when the payment failed.
    /// </summary>
    /// <remarks>
    /// The time must follow the format "YYYY-MM-DDTHH:mm:ss.sssZ" or include a timezone offset.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? Time { get; set; }

    /// <summary>
    /// Gets or sets the time for the next payment retry attempt.
    /// </summary>
    /// <remarks>
    /// The time must follow the format "YYYY-MM-DDTHH:mm:ss.sssZ" or include a timezone offset.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("next_payment_retry_time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? NextPaymentRetryTime { get; set; }
    
    /// <summary>
    /// Gets the time of the failed payment as a nullable DateTime object.
    /// </summary>
    public DateTime? TimeAsDateTime => DateTimeHelper.FromISO8601(Time);
    
    /// <summary>
    /// Gets the time for the next payment retry attempt as a nullable DateTime object.
    /// </summary>
    public DateTime? NextPaymentTimeAsDateTime => DateTimeHelper.FromISO8601(NextPaymentRetryTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}