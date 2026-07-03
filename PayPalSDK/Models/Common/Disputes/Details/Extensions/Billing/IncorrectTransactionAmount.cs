using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using Tavstal.PayPalSDK.Utils;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of an incorrect transaction amount in a PayPal dispute, including the correct transaction amount, asset, and time.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class IncorrectTransactionAmount
{
    /// <summary>
    /// Gets or sets the correct transaction amount for the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("correct_transaction_amount")]
    public Money? CorrectTransactionAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the correct transaction asset for the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("correct_transaction_asset")]
    public Asset? CorrentTransactionAsset { get; set; }
    
    /// <summary>
    /// Gets or sets the correct transaction time for the dispute in ISO 8601 format.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("correct_transaction_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CorrectTransactionTime { get; set; }
    
    /// <summary>
    /// Gets the correct transaction time as a <see cref="DateTime"/> object, if valid.
    /// </summary>
    public DateTime? CorrectTransactionTimeAsDateTime => DateTimeHelper.FromISO8601(CorrectTransactionTime);

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}