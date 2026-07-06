using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the details of the last payment made.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class LastPayment
{
    /// <summary>
    /// Gets or sets the status of the last payment.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public ECaptureStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or sets the amount of the last payment.
    /// </summary>
    /// <remarks>
    /// The amount is represented as a <see cref="Money"/> object.
    /// </remarks>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Gets or sets the time when the last payment was made.
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
    /// Gets the time of the last payment as a nullable DateTime object.
    /// </summary>
    public DateTime? TimeAsDateTime => DateTimeHelper.FromISO8601(Time);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}