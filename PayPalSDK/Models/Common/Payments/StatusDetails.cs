using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the details of a payment status, including the reason for the status.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class StatusDetails
{
    /// <summary>
    /// The reason for the payment status.
    /// This is a string with a maximum length of 64 characters and must match the regular expression "^[A-Z_]+$".
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("reason")]
    [StringLength(64)]
    [RegularExpression("^[A-Z_]+$")]
    public string? Reason { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}