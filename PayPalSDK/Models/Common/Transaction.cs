using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Models.Common.User;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a transaction in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Transaction
{
    /// <summary>
    /// Gets or sets the status of the transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the transaction.
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("id")]
    [StringLength(50)]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the amount breakdown for the transaction.
    /// </summary>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("amount_with_breakdown")]
    public AmountBreakdown? AmountWithBreakdown { get; set; }

    /// <summary>
    /// Gets or sets the name information of the payer.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("payer_name")]
    public NameInfo? PayerName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the payer.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("payer_email")]
    [StringLength(254)]
    [RegularExpression("^.+@[^\"\\-].+$")]
    public string? PayerEmail { get; set; }

    /// <summary>
    /// Gets or sets the timestamp of the transaction in ISO 8601 format.
    /// </summary>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("time")]
    [StringLength(64)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? Time { get; set; }
    
    /// <summary>
    /// Gets the timestamp of the transaction as a nullable DateTime object.
    /// </summary>
    public DateTime? TimeAsDateTime => DateTimeHelper.FromISO8601(Time);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(6, "Build")]
    public void Build() { }
}