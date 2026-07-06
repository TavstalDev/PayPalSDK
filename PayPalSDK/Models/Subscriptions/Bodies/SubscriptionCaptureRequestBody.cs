using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Subscriptions.Bodies;

/// <summary>
/// Represents the body of a request to capture a subscription payment.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SubscriptionCaptureRequestBody
{
    /// <summary>
    /// Gets or sets the note associated with the capture request.
    /// </summary>
    /// <remarks>
    /// The note must not exceed 128 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("note")]
    [StringLength(128)]
    [Required]
    public string? Note { get; set; }

    /// <summary>
    /// Gets or sets the type of capture for the subscription payment.
    /// </summary>
    /// <remarks>
    /// The capture type must not exceed 24 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("capture_type")]
    [StringLength(24)]
    public string? CaptureType { get; set; } = "OUTSTANDING_BALANCE";

    /// <summary>
    /// Gets or sets the amount to be captured for the subscription payment.
    /// </summary>
    /// <remarks>
    /// The amount is represented as a <see cref="Money"/> object.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}